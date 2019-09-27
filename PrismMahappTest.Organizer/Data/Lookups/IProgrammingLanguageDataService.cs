using PrismMahappTest.Organizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PrismMahappTest.Organizer.Data.Lookups
{
    public interface IProgrammingLanguageDataService
    {
        Task<IEnumerable<LookupItem>> GetProgrammingLanguageAsync();
    }
}
