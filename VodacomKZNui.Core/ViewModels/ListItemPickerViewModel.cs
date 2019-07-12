using MvvmHelpers;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VodacomKZNui.Core.Data;
using VodacomKZNui.Core.Extensions;
using VodacomKZNui.Core.Options;

namespace VodacomKZNui.Core.ViewModels
{
    public enum ListItemPickerMode
    {
        LoadTheFullList, // Retreives
        QueryBackingStoreForList // Will query a backing source
    }

    public class ListItemPickerViewModel<T> : PrismBaseViewModel, INavigatingAware where T : class
    {

        #region fields
        public IEnumerable<T> AllItems { get; set; }
        private IEnumerable<T> _fullListItems;
        private readonly IListPageBaseOptions _options;
        private readonly IDataService<T> _dataService;
        #endregion

        #region Constructors

        public ListItemPickerViewModel(IListPageBaseOptions options,
          INavigationService navigationService) : base(navigationService)
        {
            _fullListItems = new List<T>();
            _dataService = this as IDataService<T>;
            _options = options;
            Title = _options.Title;
            PlaceHolderText = _options.PlaceHolderText ?? "Search by name";

            ItemTappedCommand = new DelegateCommand<T>(OnItemTappedCommand);

            (this).ToObservable(x => x.SearchQueryText).Subscribe(x =>
            {
                try
                {
                    IsLoading = true;
                    if (x != null)
                    {
                        HandleSearch(x);
                    }
                    else
                    {
                        HandleSearch(string.Empty);
                    }

                }
                finally
                {
                    IsLoading = false;
                }

            });
        }

        #endregion

        #region properties
        public string PlaceHolderText { get; set; }
        public bool IsLoading { get; set; }
        public string EmptyListText { get; set; }
        public ObservableRangeCollection<ItemPickerListGrouping<string, T>> GroupedListItems { get; set; }
        public ObservableRangeCollection<T> ListItems { get; set; }
        public string SearchQueryText { get; set; }
        #endregion`

        #region Commands
        public DelegateCommand<T> ItemTappedCommand { get; set; }

        public virtual async void OnItemTappedCommand(T item)
        {
            var navParams = new NavigationParameters
            {
                { "item", item }
            };
            await _navigationService.NavigateAsync(_options.DrillDownPage, navParams);
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method is executed on page init
        /// </summary>
        /// <returns></returns>
        public virtual async Task Init()
        {
            if (_options.PickerMode == ListItemPickerMode.LoadTheFullList)
            {
                IsLoading = true;
                var observable = _dataService.GetFullList();
                observable.Subscribe(list =>
                {
                    _fullListItems = list;
                    UpdateList(list);
                    IsLoading = false;
                    AllItems = list;
                });
            }


            await Task.FromResult(IsLoading);
        }

        public virtual void HandleSearch(string x)
        {
            var list = _dataService.QueryList(_fullListItems, x);
            UpdateList(list);
        }
        public virtual async void OnNavigatingTo(INavigationParameters parameters)
        {
            await Init();
        }

        public void UpdateList(IEnumerable<T> list)
        {
            if (list == null)
            {
                list = new List<T>();
            }

            ListItems = new ObservableRangeCollection<T>(list);

           
        }


        #endregion
    }
}
