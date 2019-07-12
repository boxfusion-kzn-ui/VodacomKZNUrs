using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using VodacomKZNui.Module.Home.Model;

namespace VodacomKZNui.Module.Home.ViewModels
{
	public class SpendPageViewModel : BindableBase
	{
        ObservableCollection<Spend> spendsFund = new ObservableCollection<Spend>();
        public DelegateCommand<Spend> NavigateCommand { get; set; }
        public ObservableCollection<Spend> spendsListItems { get { return spendsFund; } }
        public SpendPageViewModel()
        {
            spendsListItems.Add(new Spend { Cost = 554.52, TransacctionType = "Oil" });
            spendsListItems.Add(new Spend { Cost = 350.13, TransacctionType = "Fuel" });

        }
	}
}
