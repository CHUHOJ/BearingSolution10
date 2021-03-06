﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Organizer.Model;
using BearingSolution10.Organizer.Data;
using BearingSolution10.Infrastructure.Base;
using System.Data.Entity;

namespace BearingSolution10.Organizer.Data.Lookups
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
