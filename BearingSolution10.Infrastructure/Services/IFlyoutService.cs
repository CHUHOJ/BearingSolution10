using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingSolution10.Infrastructure.Services
{
    public interface IFlyoutService
    {
        void ShowFlyout(string flyoutName);
        bool CanShowFlyout(string flyoutName);
    }
}
