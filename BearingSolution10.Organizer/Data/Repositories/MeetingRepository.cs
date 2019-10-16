using BearingSolution10.Infrastructure.Base;
using BearingSolution10.Organizer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;


namespace BearingSolution10.Organizer.Data.Repositories
{
    public class MeetingRepository : GenericRepository<Meeting, OrganizerDbContext>, IMeetingRepository
    {
        public MeetingRepository(OrganizerDbContext context):base(context)
        {

        }

        public async Task<List<Person>> GetAllPersonsAsync()
        {
            return await Context.Set<Person>().ToListAsync();
        }

        public async override Task<Meeting> GetByIdAsync(int id)
        {
            return await Context.Meetings
                .Include(x => x.Persons)
                .SingleOrDefaultAsync(x => x.Id == id);
        }
        public async Task ReloadPersonAsync(int personID)
        {
            DbEntityEntry<Person> dbEntityEntry = Context.ChangeTracker.Entries<Person>()
                .SingleOrDefault(x => x.Entity.Id == personID);

            if (dbEntityEntry != null)
            {
                await dbEntityEntry.ReloadAsync();
            }
        }
    }
}
