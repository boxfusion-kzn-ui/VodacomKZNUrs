using Prism.Ioc;
using VodacomKZNui.Core.ViewModels;
using VodacomKZNui.Core.Views;

namespace VodacomKZNui.Core
{
    public class CoreModule
    {
        public CoreModule(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<DynamicTabbedPage>();
        }
    }
}
