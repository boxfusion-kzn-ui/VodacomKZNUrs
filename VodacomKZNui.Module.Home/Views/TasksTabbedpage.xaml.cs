using Prism.Navigation;
using VodacomKZNui.Module.Home.ViewModels;
using Xamarin.Forms;

namespace VodacomKZNui.Module.Home.Views
{
    public partial class TasksTabbedpage : TabbedPage, INavigatingAware
    {
        public TasksTabbedpage()
        {
            InitializeComponent();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            foreach (var item in this.Children)
            {
                var page = item as TasksPage;
                var page2 = item as SummaryTaskPage;

                var viewmModel = (this?.BindingContext as TasksTabbedpageViewModel);

                if (item.BindingContext is TasksPageViewModel vm)
                {
                    vm.SetNavigationService(viewmModel.NavigationService);
                    vm.TabNumber = page?.TabNumber;
                    //Title = vm.Options.Title;
                }else
                    if (item.BindingContext is SummaryTaskPageViewModel Vm)
                {
                    Vm.SetNavigationService(viewmModel.NavigationService);
                    Vm.TabNumber = page2?.TabNumber;
                }
            }
        }
    }
}
