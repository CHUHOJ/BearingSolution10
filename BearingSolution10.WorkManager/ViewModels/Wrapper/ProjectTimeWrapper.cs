using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class ProjectTimeWrapper : ModelWrapper<ProjectTime>
    {
        public ProjectTimeWrapper(ProjectTime model) : base(model) { }

        public int ProjectTimeID { get { return Model.ProjectTimeID; } }

        public int WorkID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public DateTime Date
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public double Hour
        {
            get { return GetValue<double>(); }
            set { SetValue(value); }
        }

        public Work Work
        {
            get { return GetValue<Work>(); }
            set { SetValue(value); }
        }
    }
}
