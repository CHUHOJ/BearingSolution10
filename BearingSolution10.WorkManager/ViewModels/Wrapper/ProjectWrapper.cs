using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class ProjectWrapper : ModelWrapper<Project>
    {
        public ProjectWrapper(Project model) : base(model) { }


        public int ProjectID { get { return Model.ProjectID; } }

        public string ProjectNo
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string ProjectTitle
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int? CustomerID
        {
            get { return GetValue<int?>(); }
            set { SetValue(value); }
        }

        public string Responsible
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Note
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int Level
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public Customer Customer
        {
            get { return GetValue<Customer>(); }
            set { SetValue(value); }
        }
    }
}
