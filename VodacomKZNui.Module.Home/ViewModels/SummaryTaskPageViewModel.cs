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
	public class SummaryTaskPageViewModel : PrismBaseViewModel
    {
        public int? TabNumber { get; set; }

        public SummaryTaskPageViewModel(INavigationService navigationService, IUnityContainer unityContainer) : base(navigationService)
        {

        }
    }
}
