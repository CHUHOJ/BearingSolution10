using System.Windows.Controls;
using BearingSolution10.Organizer.ViewModels;

namespace BearingSolution10.Organizer.Views
{
    /// <summary>
    /// Interaction logic for OrganizerMainView
    /// </summary>
    public partial class OrganizerMainView : UserControl
    {
        public OrganizerMainView()
        {
            InitializeComponent();
            Loaded += OrganizerMainView_Loaded;
        }

        private async void OrganizerMainView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.DataContext is OrganizerMainViewModel)
            {
                var vm = this.DataContext as OrganizerMainViewModel;
                await vm.LoadAsync();
            }
        }
    }
}
