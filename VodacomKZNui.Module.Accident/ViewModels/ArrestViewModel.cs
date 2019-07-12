using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using VodacomKZNui.Core.Data;
using VodacomKZNui.Core.ViewModels;
using VodacomKZNui.Module.Accident.Model;
using VodacomKZNui.Module.Accident.Options;
using VodacomKZNui.Module.Accident.Service;

namespace VodacomKZNui.Module.Accident.ViewModels
{
	public class ArrestViewModel : ListItemPickerViewModel<Arrest>, IDataService<Arrest>
    {
        private readonly IArrestUpdate _service;
        private IEnumerable<Arrest> _fullListItems;
        ObservableCollection<Arrest> Arrests = new ObservableCollection<Arrest>();
        public ObservableCollection<Arrest> ArrestsUpdateList { get { return Arrests; } }


        public ArrestViewModel(IArrestModuleConfiguration options,  IArrestUpdate service,INavigationService navigationService) : base(options.ArrestList, navigationService)
        {

            ArrestsUpdateList.Add(new Arrest { ArrestId = 1, CaseNumber = "847-745", IdNumber = "9206116387082", Initial = "S P", LastName = "Mdluli", InvistigatorOfficer = "Sabelo", NameOfPoliceStation = "Pretoria" });
            ArrestsUpdateList.Add(new Arrest { ArrestId = 2, CaseNumber = "747-745", IdNumber = "9206116387082", Initial = "F F", LastName = "Mamba", InvistigatorOfficer = "Gift", NameOfPoliceStation = "Kwamashu" });
            ArrestsUpdateList.Add(new Arrest { ArrestId = 3, CaseNumber = "447-745", IdNumber = "9206116387082", Initial = "J P", LastName = "Mamabolo", InvistigatorOfficer = "Lethabo", NameOfPoliceStation = "Polokwane" });
  
        }



        public IObservable<IEnumerable<Arrest>> GetFullList()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arrest> QueryList(IEnumerable<Arrest> list, string query)
        {
            throw new NotImplementedException();
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
           
           
        }
    }
}
