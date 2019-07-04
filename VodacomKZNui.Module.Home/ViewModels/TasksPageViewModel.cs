using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using VodacomKZNui.Core.ViewModels;

namespace VodacomKZNui.Module.Home.ViewModels
{
	public class TasksPageViewModel : PrismBaseViewModel
    {
        public int? TabNumber { get; set; }
        private IUnityContainer _unityContainer { get; set; }
        public TasksPageViewModel( INavigationService navigationService, IUnityContainer unityContainer) : base(navigationService)
        {
            
        }
    }
}
