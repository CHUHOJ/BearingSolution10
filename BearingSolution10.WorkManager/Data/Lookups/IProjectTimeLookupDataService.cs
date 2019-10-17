using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;

namespace BearingSolution10.WorkManager.Data
{
    public interface IProjectTimeLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetProjectTimeLookupAsync();
    }
}
