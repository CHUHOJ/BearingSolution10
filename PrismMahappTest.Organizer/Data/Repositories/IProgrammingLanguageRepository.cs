using System.Threading.Tasks;
using PrismMahappTest.Infrastructure.Interfaces;
using PrismMahappTest.Organizer.Model;

namespace PrismMahappTest.Organizer.Data.Repositories
{
    public interface IProgrammingLanguageRepository:IGenericRepository<ProgrammingLanguage>
    {
        Task<bool> IsReferencesByPersonAsync(int programingLanguageID);
    }
}
