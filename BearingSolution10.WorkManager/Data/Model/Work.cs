using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BearingSolution10.WorkManager.Data
{

    public class Work
    {
        public Work()
        {
            ProjectTimes = new Collection<ProjectTime>();
            Attachments = new Collection<Attachment>();
        }

        public int WorkID { get; set; }

        [Required]
        [StringLength(50)]
        public string JobType { get; set; }

        [StringLength(50)]
        public string BearingType { get; set; }

        [StringLength(50)]
        public string ProcessNo { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        public float? WorkingHour { get; set; }

        public string Note { get; set; }

        [Column(TypeName = "date")]
        public DateTime AssignedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TargetDate { get; set; }

        [StringLength(50)]
        public string WorkTitle { get; set; }

        [StringLength(50)]
        public string BearingDesignation { get; set; }

        [StringLength(50)]
        public string Application { get; set; }

        public Customer Customer { get; set; }

        public Project Project { get; set; }

        public ICollection<ProjectTime> ProjectTimes { get; set; }

        [Required]
        public User Assigner { get; set; }

        public User ResponsibleUser { get; set; }

        public ICollection<Attachment> Attachments { get; set; }
    }
}
