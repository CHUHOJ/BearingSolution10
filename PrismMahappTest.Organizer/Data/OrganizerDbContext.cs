using PrismMahappTest.Organizer.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PrismMahappTest.Organizer.Data
{
    public class OrganizerDbContext:DbContext
    {
        public OrganizerDbContext():base("PrismMahappOrganizerDB")
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public DbSet<PersonPhoneNumber> PersonPhoneNumbers { get; set; }

        public DbSet<Meeting> Meetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
