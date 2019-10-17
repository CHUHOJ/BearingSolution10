using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BearingSolution10.WorkManager.Data
{
    public class Customer
    {
        public Customer()
        {
            Projects = new Collection<Project>();
            Works = new Collection<Work>();
        }

        public int CustomerID { get; set; }

        [Required]
        [Index(IsUnique =true)]
        [StringLength(50)]
        public string CustomerName { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
