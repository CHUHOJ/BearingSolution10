using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismMahappTest.Organizer.Model;
using PrismMahappTest.Organizer.Data;
using System.Data.Entity;

namespace PrismMahappTest.Organizer.Data.Lookups
{
    public class LookupDataService : IPersonLookupDataService, IProgrammingLanguageDataService, IMeetingLookupDataService
    {

        private readonly Func<OrganizerDbContext> _contextCreator;
        public LookupDataService(Func<OrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetMeetingLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Meetings.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.Id,
                        DisplayMember = x.Title
                    }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetPersonLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Persons.AsNoTracking()
                    .Select(x =>
                    new LookupItem()
                    {
                        Id = x.Id,
                        DisplayMember = x.FirstName + " " + x.LastName
                    }).ToListAsync();

            }
        }

        public async Task<IEnumerable<LookupItem>> GetProgrammingLanguageAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.ProgrammingLanguages.AsNoTracking()
                    .Select(x =>
                    new LookupItem()
                    {
                        Id = x.Id,
                        DisplayMember = x.Name
                    }).ToListAsync();

            }
        }
    }
}
