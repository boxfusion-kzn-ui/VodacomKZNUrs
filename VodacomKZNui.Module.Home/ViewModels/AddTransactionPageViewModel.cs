using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using VodacomKZNui.Module.Home.Model;

namespace VodacomKZNui.Module.Home.ViewModels
{
	public class AddTransactionPageViewModel : BindableBase
	{
        ObservableCollection<Transactions> transactions = new ObservableCollection<Transactions>();
        public DelegateCommand<Transactions> NavigateCommand { get; set; }
        public ObservableCollection<Transactions> transactionsItemsDetail { get { return transactions; } }
        public AddTransactionPageViewModel()
        {
            transactionsItemsDetail.Add(new Transactions { ItemPrice = "254.23", ItemSampleNumber = "2453841", TransactionType = "Troll" });

        }
	}
}
