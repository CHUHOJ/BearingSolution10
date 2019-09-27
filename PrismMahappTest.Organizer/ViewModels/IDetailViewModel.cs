using System.Threading.Tasks;

namespace PrismMahappTest.Organizer.ViewModels
{
    public interface IDetailViewModel
    {
        Task LoadAsync(int id);
        bool HasChanges { get; }
        int Id { get; }
    }
}
