using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismMahappTest.Infrastructure.Interfaces;
using PrismMahappTest.Organizer.Model;

namespace PrismMahappTest.Organizer.Data.Repositories
{
    public interface IMeetingRepository:IGenericRepository<Meeting>
    {
        Task<List<Person>> GetAllPersonsAsync();
        Task ReloadPersonAsync(int personID);
    }
}
