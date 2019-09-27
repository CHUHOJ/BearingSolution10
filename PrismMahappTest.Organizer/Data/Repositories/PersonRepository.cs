using PrismMahappTest.Infrastructure.Base;
using PrismMahappTest.Organizer.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
namespace PrismMahappTest.Organizer.Data.Repositories
{
    public class PersonRepository : GenericRepository<Person, OrganizerDbContext>, IPersonRepository
    {
        public PersonRepository(OrganizerDbContext context):base(context)
        {

        }

        public override async Task<Person> GetByIdAsync(int id)
        {
            return await Context.Persons.Include(p => p.PhoneNumbers)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> HasMeetingsAsync(int personId)
        {
            return await Context.Meetings.AsNoTracking()
                .AnyAsync(x => x.Persons.Any(p => p.Id == personId));
        }

        public void RemovePhoneNumber(PersonPhoneNumber model)
        {
            Context.PersonPhoneNumbers.Remove(model);
        }
    }
}
