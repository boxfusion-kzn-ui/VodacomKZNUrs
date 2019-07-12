using Prism.Navigation;
using System;
using VodacomKZNui.Module.Home.ViewModels;
using Xamarin.Forms;

namespace VodacomKZNui.Module.Home.Views
{
    public partial class TasksTabbedpage : TabbedPage, INavigatingAware
    {
        public TasksTabbedpage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            foreach (var item in this.Children)
            {
                var page1 = item as TasksPage;
                var page2 = item as SummaryTaskPage;

                var viewmModel = (this?.BindingContext as TasksTabbedpageViewModel);

                if (item.BindingContext is TasksPageViewModel vm)
                {
                    //vm.SetNavigationService(viewmModel.NavigationService);
                   // vm.TabNumber = page1?.TabNumber;
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
