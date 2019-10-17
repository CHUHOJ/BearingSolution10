using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace BearingSolution10.WorkManager.Data
{

    public class Project
    {
        public Project()
        {
            Works = new Collection<Work>();
        }

        public int ProjectID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProjectNo { get; set; }

        [Required]
        public string ProjectTitle { get; set; }

        public int? CustomerID { get; set; }

        [StringLength(50)]
        public string Responsible { get; set; }

        public string Note { get; set; }

        public int Level { get; set; }

        public Customer Customer { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
