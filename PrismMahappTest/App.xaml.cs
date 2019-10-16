using PrismMahappTest.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using PrismMahappTest.Infrastructure.Constants;
using PrismMahappTest.Infrastructure.Services;
using PrismMahappTest.Infrastructure;
using static PrismMahappTest.Infrastructure.ApplicationCommands;
using PrismMahappTest.Organizer;
using PrismMahappTest.ModuleA;
using PrismMahappTest.ModuleB;
using System;

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
            moduleCatalog.AddModule(typeof(ModuleAModule));
            //// Register ModuleB
            //moduleCatalog.AddModule(typeof(ModuleBModule));

            moduleCatalog.AddModule(typeof(OrganizerModule));
        }

        private void Application_DispatcherUnhandledException(object sender,
        System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Unexpected error occured:" +
                Environment.NewLine + e.Exception.Message, "Unexpected error");

            e.Handled = true;
        }
    }
}
