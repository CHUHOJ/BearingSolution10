using System.Threading.Tasks;
using PrismMahappTest.Infrastructure.Interfaces;
using PrismMahappTest.Organizer.Model;

namespace PrismMahappTest.Organizer.Data.Repositories
{
    public interface IPersonRepository:IGenericRepository<Person>
    {
        void RemovePhoneNumber(PersonPhoneNumber model);

        Task<bool> HasMeetingsAsync(int personId);
    }
}
