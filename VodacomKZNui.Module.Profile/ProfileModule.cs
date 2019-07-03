using Prism.Ioc;
using Prism.Modularity;
using VodacomKZNui.Module.Profile.Views;
using VodacomKZNui.Module.Profile.ViewModels;

namespace VodacomKZNui.Module.Profile
{
    public class ProfileModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        }
    }
}
