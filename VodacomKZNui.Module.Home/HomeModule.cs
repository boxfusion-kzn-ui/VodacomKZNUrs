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
        }
    }
}
