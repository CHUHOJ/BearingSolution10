using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Interfaces;
using BearingSolution10.Organizer.Model;

namespace BearingSolution10.Organizer.Data.Repositories
{
    public interface IProgrammingLanguageRepository:IGenericRepository<ProgrammingLanguage>
    {
        Task<bool> IsReferencesByPersonAsync(int programingLanguageID);
    }
}
