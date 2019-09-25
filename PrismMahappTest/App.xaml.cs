using PrismMahappTest.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using PrismMahappTest.Infrastructure.Constants;
using PrismMahappTest.Infrastructure.Services;
using PrismMahappTest.Infrastructure;
using static PrismMahappTest.Infrastructure.ApplicationCommands;

namespace PrismMahappTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {


            containerRegistry.Register<IApplicationCommands, ApplicationCommandsProxy>();
            containerRegistry.RegisterInstance<IFlyoutService>(Container.Resolve<FlyoutService>());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule(typeof(ModuleA.ModuleAModule));
            // Register ModuleB
            moduleCatalog.AddModule(typeof(ModuleB.ModuleBModule));
        }
    }
}
