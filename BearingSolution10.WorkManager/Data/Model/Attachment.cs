using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BearingSolution10.WorkManager.Data
{
    public class Attachment
    {
        public Attachment()
        {
            Works = new Collection<Work>();
        }

        public int AttachmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string FileName { get; set; }

        [Required]
        [StringLength(50)]
        public string Extension { get; set; }

        [Required]
        public byte[] BinaryData { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public DateTime CreatedTime { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
