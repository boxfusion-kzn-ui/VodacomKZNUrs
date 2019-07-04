using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using VodacomKZNui.Core.ViewModels;

namespace VodacomKZNui.Module.Home.ViewModels
{
	public class TasksTabbedpageViewModel : PrismBaseViewModel
    {
        public INavigationService NavigationService { get; set; }
        public TasksTabbedpageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
