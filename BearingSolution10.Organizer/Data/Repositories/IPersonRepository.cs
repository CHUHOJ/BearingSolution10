using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Interfaces;
using BearingSolution10.Organizer.Model;

namespace BearingSolution10.Organizer.Data.Repositories
{
    public interface IPersonRepository:IGenericRepository<Person>
    {
        void RemovePhoneNumber(PersonPhoneNumber model);

        Task<bool> HasMeetingsAsync(int personId);
    }
}
