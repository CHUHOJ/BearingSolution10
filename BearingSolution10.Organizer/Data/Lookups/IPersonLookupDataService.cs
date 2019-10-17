using BearingSolution10.Infrastructure.Base;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace BearingSolution10.Organizer.Data.Lookups
{
    public interface IPersonLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetPersonLookupAsync();
    }
}
