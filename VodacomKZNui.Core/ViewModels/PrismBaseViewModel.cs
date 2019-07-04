using Akavache;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VodacomKZNui.Core.Repositories;
using Xamarin.Essentials;

namespace VodacomKZNui.Core.ViewModels
{
    public class PrismBaseViewModel : BindableBase, INavigatingAware, INotifyPropertyChanged, IDestructible
    {
        private bool _isBusy;
        private string _title;

        public PrismBaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        protected INavigationService _navigationService { get; private set; }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);

        }

        public bool IsBusy
        {
            get => _isBusy;
            set { SetProperty(ref _isBusy, value, () => RaisePropertyChanged(nameof(IsNotBusy))); }
        }

        public bool IsNotBusy => !IsBusy;

        public bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;


        public virtual void SetNavigationService(INavigationService navigation)
        {
            _navigationService = navigation;
        }


        protected void GetFromCache<T>(string key, Task<T> remoteTask, Action<T> callbackSuccess,
            DateTime? expirateDate = null)
        {
            if (!expirateDate.HasValue)
            {
                expirateDate = DateTime.Now.AddMinutes(10);
            }

            BlobCacheProvider.SheshaBlobCache.GetAndFetchLatest(key,
                async () => await remoteTask,
                null,
                expirateDate
            ).Catch(Observable.Return(default(T))).Subscribe(callbackSuccess);
        }
       
        public virtual  void OnNavigatingTo(INavigationParameters parameters)
        {
           
        }

        public virtual void Destroy()
        {
            GC.Collect();
        }


        public async Task<bool> CheckLocationPermissions(params Permission[] permissions)
        {
            return await CheckPermissions(permissions);
        }

        private async Task<bool> CheckPermissions(params Permission[] permissions)
        {
            List<Task<PermissionResult>> taskList = new List<Task<PermissionResult>>();
            foreach (var item in permissions)
            {
                taskList.Add(ChecKPermissionReults(item));
            }

            var successes = await Task.WhenAll(taskList);

            var outstandingPermission = successes.Where(e => e.PermissionStatus != PermissionStatus.Granted).ToList();

            if (!outstandingPermission.Any())
            {
                return true;
            }

            var grantedPermissions = await CrossPermissions.Current.RequestPermissionsAsync(outstandingPermission.Select(e => e.Permission).ToArray());

            var authorised = grantedPermissions.Where(e => outstandingPermission.Select(x => x.Permission).Contains(e.Key)).ToList();

            return authorised.All(r => r.Value == PermissionStatus.Granted);
        }

        private async Task<PermissionResult> ChecKPermissionReults(Permission item)
        {
            var results = await CrossPermissions.Current.CheckPermissionStatusAsync(item);
            return new PermissionResult
            {
                Permission = item,
                PermissionStatus = results
            };
        }

        private class PermissionResult
        {
            public Permission Permission { get; set; }

            public PermissionStatus PermissionStatus { get; set; }
        }
        public async Task NavigateBack()
        {
            await _navigationService.GoBackAsync();
        }
    }
}
