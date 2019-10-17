using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BearingSolution10.WorkManager.Data
{
    public class User
    {
        public User()
        {
            DayOffs = new Collection<DayOff>();
            WorksAsAssigner = new Collection<Work>();
            WorksAsReponsibleUser = new Collection<Work>();
        }

        public int UserID { get; set; }

        [Required]
        [Index(IsUnique =true)]
        [StringLength(50)]
        public string ShortAlias { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [EmailAddress]
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Role { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        public ICollection<DayOff> DayOffs { get; set; }

        [InverseProperty("Assigner")]
        public ICollection<Work> WorksAsAssigner { get; set; }

        [InverseProperty("ResponsibleUser")]
        public ICollection<Work> WorksAsReponsibleUser { get; set; }
    }
}
