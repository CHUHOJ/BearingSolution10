using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.Organizer.Model;
using System.Data.Entity;

namespace BearingSolution10.Organizer.Data.Repositories
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
