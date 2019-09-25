using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismMahappTest.Infrastructure.Interfaces;
using PrismMahappTest.Infrastructure.Constants;
using static PrismMahappTest.Infrastructure.ApplicationCommands;
using System.Windows.Input;
using Prism.Commands;
using MahApps.Metro.Controls;

namespace PrismMahappTest.Infrastructure.Services
{
    public class FlyoutService : IFlyoutService
    {
        IRegionManager _regionManager;

        public ICommand ShowFlyoutCommand { get; private set; }
        public FlyoutService(IRegionManager rm, IApplicationCommands applicationCommands)
        {
            _regionManager = rm;

            ShowFlyoutCommand = new DelegateCommand<string>(ShowFlyout, CanShowFlyout);
            applicationCommands.ShowFlyoutCommand.RegisterCommand(ShowFlyoutCommand);
           
        }
        public bool CanShowFlyout(string flyoutName)
        {
            return true;
        }

        public void ShowFlyout(string flyoutName)
        {
            var region = _regionManager.Regions[RegionNames.FlyoutRegion];

            if(region != null)
            {
                var flyout = region.Views.Where(v => v is IFlyoutView && ((IFlyoutView)v).FlyoutName.Equals(flyoutName)).FirstOrDefault() as Flyout;

                if (flyout != null)
                {
                    flyout.IsOpen = !flyout.IsOpen;
                }
            }
        }
    }
}
