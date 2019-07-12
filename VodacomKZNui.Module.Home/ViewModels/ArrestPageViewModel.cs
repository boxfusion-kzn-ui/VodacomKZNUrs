using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using VodacomKZNui.Module.Home.Model;

namespace VodacomKZNui.Module.Home.ViewModels
{
	public class ArrestPageViewModel : BindableBase
	{
        ObservableCollection<Arrest> Arrests = new ObservableCollection<Arrest>();
        public DelegateCommand<Arrest> NavigateCommand { get; set; }
        public ObservableCollection<Arrest> ArrestsUpdateList { get { return Arrests; } }

        public ArrestPageViewModel(INavigationService navigationService) 
        {

            NavigateCommand = new DelegateCommand<Arrest>(OnSelectedItemAsync);

            ArrestsUpdateList.Add(new Arrest { ArrestId = 1, CaseNumber = "847-745", IdNumber = "9206116387082", Initial = "S P", LastName = "Mdluli", InvistigatorOfficer = "Sabelo", NameOfPoliceStation = "Pretoria" });
            ArrestsUpdateList.Add(new Arrest { ArrestId = 2, CaseNumber = "747-745", IdNumber = "9206116387082", Initial = "F F", LastName = "Mamba", InvistigatorOfficer = "Gift", NameOfPoliceStation = "Kwamashu" });
            ArrestsUpdateList.Add(new Arrest { ArrestId = 3, CaseNumber = "447-745", IdNumber = "9206116387082", Initial = "J P", LastName = "Mamabolo", InvistigatorOfficer = "Lethabo", NameOfPoliceStation = "Polokwane" });
        }

        private async void OnSelectedItemAsync(Arrest  item)
        {
            //var navparams = new NavigationParameters();
            //navparams.Add("arrestId", item.ArrestId);
            //await _navigationService.NavigateAsync(item.Url, navparams)
            
        }
    }
}
