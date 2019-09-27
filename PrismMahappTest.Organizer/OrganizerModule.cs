using PrismMahappTest.Organizer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismMahappTest.Organizer.Data;
using PrismMahappTest.Organizer.Data.Lookups;
using PrismMahappTest.Organizer.Data.Repositories;
using PrismMahappTest.Organizer.ViewModels;
using PrismMahappTest.Infrastructure.Services;
using PrismMahappTest.Infrastructure.Constants;
using MahApps.Metro.Controls.Dialogs;

namespace PrismMahappTest.Organizer
{
    public class OrganizerModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(OrganizerMainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<OrganizerDbContext>();
            containerRegistry.Register<IMessageDialogService, MessageDialogService>();
            containerRegistry.Register<IDetailedViewModelFactory, DetailViewModelFactory>();
            containerRegistry.Register<IMeetingLookupDataService, LookupDataService>();
            containerRegistry.Register<IPersonLookupDataService, LookupDataService>();
            containerRegistry.Register<IProgrammingLanguageDataService, LookupDataService>();
            containerRegistry.Register<IMeetingRepository, MeetingRepository>();
            containerRegistry.Register<IPersonRepository, PersonRepository>();
            containerRegistry.Register<INavigationViewModel, NavigationViewModel>();
            containerRegistry.Register<IProgrammingLanguageRepository, ProgrammingLanguageRepository>();
            containerRegistry.RegisterInstance<IDialogCoordinator>(DialogCoordinator.Instance);
        }
    }
}