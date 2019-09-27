using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Prism.Regions;
using PrismMahappTest.Infrastructure.Constants;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMahappTest.Infrastructure.Services
{
    public class MessageDialogService : IMessageDialogService
    {

        public MessageDialogService()
        {
          

        }
        public async Task ShowInfoDialogAsync(string text)
        {
            if (Application.Current.Windows.OfType<MetroWindow>().SingleOrDefault(x => x.IsActive) is MetroWindow window)
            {
                await window.ShowMessageAsync("Info", text);
            }
            else
            {
                MessageBox.Show(text, "Info");
            }
        }

        public async Task<MessageDialogResult> ShowOkCancelDialogAsync(string text, string title)
        {
            MessageDialogResult result;

            if (Application.Current.Windows.OfType<MetroWindow>().SingleOrDefault(x => x.IsActive) is MetroWindow window)
            {
               var res= await window.ShowMessageAsync(title, text, MessageDialogStyle.AffirmativeAndNegative);
               
                result = res== MahApps.Metro.Controls.Dialogs.MessageDialogResult.Affirmative
                                ? MessageDialogResult.OK
                                : MessageDialogResult.Cancel;
            }
            else
            {
               var res = MessageBox.Show(text, title, MessageBoxButton.OKCancel);
                result = res == MessageBoxResult.OK ? MessageDialogResult.OK : MessageDialogResult.Cancel;
            }

            return result;

        }
    }

    public enum MessageDialogResult
    {
        OK, Cancel
    }
}
