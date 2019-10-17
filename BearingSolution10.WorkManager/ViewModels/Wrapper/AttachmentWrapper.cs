using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class AttachmentWrapper : ModelWrapper<Attachment>
    {
        public AttachmentWrapper(Attachment model) : base(model) { }

        public int AttachmentID { get { return Model.AttachmentID; } }

        public string FileName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Extension
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public byte[] BinaryData
        {
            get { return GetValue<byte[]>(); }
            set { SetValue(value); }
        }
    }
}
