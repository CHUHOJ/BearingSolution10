using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace BearingSolution10.WorkManager.Data
{
    public class ProjectTime
    {
        public int ProjectTimeID { get; set; }

        [Index("IX_ProjectTime", 2, IsUnique = true)]
        public int WorkID { get; set; }

        [Column(TypeName = "date")]
        [Index("IX_ProjectTime", 2, IsUnique = true)]
        public DateTime Date { get; set; }

        public double Hour { get; set; }

        public Work Work { get; set; }
    }
}
