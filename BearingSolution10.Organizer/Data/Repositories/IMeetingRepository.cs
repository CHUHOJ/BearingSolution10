using System.Collections.Generic;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.Organizer.Model;

namespace BearingSolution10.Organizer.Data.Repositories
{
    public interface IMeetingRepository:IGenericRepository<Meeting>
    {
        Task<List<Person>> GetAllPersonsAsync();
        Task ReloadPersonAsync(int personID);
    }
}
