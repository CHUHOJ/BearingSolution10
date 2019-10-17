using BearingSolution10.Organizer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using BearingSolution10.Organizer.Data;
using BearingSolution10.Organizer.Data.Lookups;
using BearingSolution10.Organizer.Data.Repositories;
using BearingSolution10.Organizer.ViewModels;
using BearingSolution10.Infrastructure.Services;
using BearingSolution10.Infrastructure.Constants;


namespace BearingSolution10.Organizer
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

        }
    }
}