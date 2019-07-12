using Prism.Ioc;
using Prism.Modularity;
using VodacomKZNui.Module.Accident.Views;
using VodacomKZNui.Module.Accident.ViewModels;

namespace VodacomKZNui.Module.Accident
{
    public class AccidentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Arrest, ArrestViewModel>();
        }
    }
}
