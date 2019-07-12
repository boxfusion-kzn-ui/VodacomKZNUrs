using Prism.Ioc;
using Prism.Modularity;
using VodacomKZNui.Module.Home.Views;
using VodacomKZNui.Module.Home.ViewModels;

namespace VodacomKZNui.Module.Home
{
    public class HomeModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TasksPage, TasksPageViewModel>();
            containerRegistry.RegisterForNavigation<SummaryTaskPage, SummaryTaskPageViewModel>();
            containerRegistry.RegisterForNavigation<TasksTabbedpage, TasksTabbedpageViewModel>();
            containerRegistry.RegisterForNavigation<ArrestPage, ArrestPageViewModel>();
            containerRegistry.RegisterForNavigation<ArrestUpdateDetailsPage, ArrestUpdateDetailsPageViewModel>();
            containerRegistry.RegisterForNavigation<SpendPage, SpendPageViewModel>();
            containerRegistry.RegisterForNavigation<AddTransactionPage, AddTransactionPageViewModel>();
        }
    }
}
