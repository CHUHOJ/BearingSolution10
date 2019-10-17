using System.Data.Entity;


namespace BearingSolution10.WorkManager.Data
{

    public partial class WorkEntity : DbContext
    {
        public WorkEntity(): base("WorkEntitiesV3")
        {

        }

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DayOff> DayOffs { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectTime> ProjectTimes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Work> Works { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }


}
