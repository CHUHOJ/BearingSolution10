using BearingSolution10.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using BearingSolution10.Infrastructure.Constants;
using BearingSolution10.Infrastructure.Services;
using BearingSolution10.Infrastructure;
using static BearingSolution10.Infrastructure.ApplicationCommands;
using BearingSolution10.Organizer;
using BearingSolution10.ModuleA;
using BearingSolution10.ModuleB;
using System;

namespace BearingSolution10
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
