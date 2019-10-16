using BearingSolution10.ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using BearingSolution10.Infrastructure.Constants;

namespace BearingSolution10.ModuleA
{
    public class ModuleAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            // Titlebar
            regionManager.RegisterViewWithRegion(RegionNames.RightWindowCommandsRegions, typeof(RightTitlebarCommands));
            //regionManager.RegisterViewWithRegion(RegionNames.RightWindowCommandsRegions, typeof(RightTitlebarCommands));

            // Flyouts
            regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(C1Flyout));
            regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(C2Flyout));

            // Tiles
            //regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(HomeTiles));
            //regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(HomeTiles));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}