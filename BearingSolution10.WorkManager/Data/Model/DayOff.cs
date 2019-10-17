using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BearingSolution10.WorkManager.Data
{ 
    public class DayOff
    {
        public int DayOffID { get; set; }

        [StringLength(50)]
        [Index("IX_DayOff",1,IsUnique =true)]
        public string UserID { get; set; }


        [Column(TypeName = "date")]
        [Index("IX_DayOff", 2, IsUnique = true)]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public User User { get; set; }
    }
}
