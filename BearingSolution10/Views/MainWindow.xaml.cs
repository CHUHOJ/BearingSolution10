using MahApps.Metro.Controls;
using Prism.Regions;
using BearingSolution10.Infrastructure.Constants;
using System.Windows;

namespace BearingSolution10.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            // The RegionManager.RegionName attached property XAML-Declaration doesn't work for this scenario (object declarated outside the logical tree)
            // theses objects are not part of the logical tree, hence the parent that has the region manager to use (the Window) cannot be found using LogicalTreeHelper.FindParent 
            // therefore the regionManager is never found and cannot be assigned automatically by Prism.  This means we have to handle this ourselves
            if (regionManager != null)
            {
                SetRegionManager(regionManager, this.leftWindowsCommandRegion, RegionNames.LeftWindowCommandsRegions);
                //SetRegionManager(regionManager, this.rightWindowsCommandRegion, RegionNames.RightWindowCommandsRegions);
                SetRegionManager(regionManager, this.flyoutsControlRegion, RegionNames.FlyoutRegion);
                //SetRegionManager(regionManager, this.metroWindow, RegionNames.MetroWindow);
            }

            //regionManager.RegisterViewWithRegion(RegionNames.RightWindowCommandsRegions, typeof(RightTitlebarCommands));
        }

        void SetRegionManager(IRegionManager regionManager, DependencyObject regionTarget, string regionName)
        {
            RegionManager.SetRegionName(regionTarget, regionName);
            RegionManager.SetRegionManager(regionTarget, regionManager);
        }
    }
}
