using MahApps.Metro.Controls;
using BearingSolution10.Infrastructure.Constants;
using BearingSolution10.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BearingSolution10.ModuleA.Views
{
    /// <summary>
    /// Interaction logic for C1Flyout.xaml
    /// </summary>
    public partial class C1Flyout : Flyout, IFlyoutView
    {
        public C1Flyout()
        {
            InitializeComponent();
        }

        public string FlyoutName
        {
            get
            {
                return FlyoutNames.ModuleAC1Flyout;
            }
        }
    }
}
