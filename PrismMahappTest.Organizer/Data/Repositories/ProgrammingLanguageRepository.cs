using System.Threading.Tasks;
using PrismMahappTest.Infrastructure.Base;
using PrismMahappTest.Organizer.Model;
using System.Data.Entity;

namespace PrismMahappTest.Organizer.Data.Repositories
{
    public class ProgrammingLanguageRepository : GenericRepository<ProgrammingLanguage, OrganizerDbContext>,IProgrammingLanguageRepository
    {
        public ProgrammingLanguageRepository(OrganizerDbContext context) : base(context) { }

        public async Task<bool> IsReferencesByPersonAsync(int programingLanguageID)
        {
            return await Context.Persons.AsNoTracking()
                .AnyAsync(x => x.FavouriteLanguageId == programingLanguageID);
        }
    }
}
