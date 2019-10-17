using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;



namespace BearingSolution10.WorkManager.Data
{
    public class LookupDataService : IAttachmentLookupDataService, ICustomerLookupDataService, IDayOffLookupDataService,
        IProjectLookupDataService, IProjectTimeLookupDataService, IUserLookupDataService, IWorkLookupDataService
    {

        private readonly Func<WorkEntity> _contextCreator;
        public LookupDataService(Func<WorkEntity> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetAttachmentLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Attachments.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.AttachmentID,
                        DisplayMember = x.FileName + "." + x.Extension
                    }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetCustomerLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Customers.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.CustomerID,
                        DisplayMember = x.CustomerName
                    }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetDayOffLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.DayOffs.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.DayOffID,
                        DisplayMember = x.Date+" " + x.Type + " " + x.User.ShortAlias
                    }).ToListAsync();
            }
        }



        public async Task<IEnumerable<LookupItem>> GetProjectLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Projects.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.ProjectID,
                        DisplayMember = x.ProjectNo + " " + x.ProjectTitle
                    }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetProjectTimeLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.ProjectTimes.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.ProjectTimeID,
                        DisplayMember = x.WorkID+": "+x.Date
                    }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetUserLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Users.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.UserID,
                        DisplayMember = x.ShortAlias
                    }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LookupItem>> GetWorkLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Works.AsNoTracking()
                    .Select(x => new LookupItem()
                    {
                        Id = x.WorkID,
                        DisplayMember = x.WorkTitle
                    }).ToListAsync();
            }
        }
    }
}
