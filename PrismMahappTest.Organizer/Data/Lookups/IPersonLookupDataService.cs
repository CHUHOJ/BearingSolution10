using PrismMahappTest.Organizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace PrismMahappTest.Organizer.Data.Lookups
{
    public interface IPersonLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetPersonLookupAsync();
    }
}
