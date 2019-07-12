using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace VodacomKZNui.Module.Accident.Views
{
    public partial class Arrest : ContentPage
    {
        ObservableCollection<Arrest> Arrests = new ObservableCollection<Arrest>();

        public ObservableCollection<Arrest> ArrestsUpdateList { get { return Arrests; } }
        public Arrest()
        {
            ArrestUpdate.ItemsSource = ArrestsUpdateList;
         
            InitializeComponent();
        }
    }
}
