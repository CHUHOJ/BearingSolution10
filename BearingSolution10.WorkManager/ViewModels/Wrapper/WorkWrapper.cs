using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class WorkWrapper : ModelWrapper<Work>
    {
        public WorkWrapper(Work model) : base(model) { }

        public int WorkID { get { return Model.WorkID; } }

        public string JobType
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string BearingType
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string ProcessNo
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string Region
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public DateTime? StartDate
        {
            get { return GetValue<DateTime?>(); }
            set { SetValue(value); }
        }


        public DateTime? EndDate
        {
            get { return GetValue<DateTime?>(); }
            set { SetValue(value); }
        }

        public float? WorkingHour
        {
            get { return GetValue<float?>(); }
            set { SetValue(value); }
        }

        public string Note
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public DateTime AssignedDate
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public DateTime? TargetDate
        {
            get { return GetValue<DateTime?>(); }
            set { SetValue(value); }
        }

        public string WorkTitle
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string BearingDesignation
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


        public string Application
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public Customer Customer
        {
            get { return GetValue<Customer>(); }
            set { SetValue(value); }
        }

        public Project Project
        {
            get { return GetValue<Project>(); }
            set { SetValue(value); }
        }

        public User Assigner
        {
            get { return GetValue<User>(); }
            set { SetValue(value); }
        }

        public User ResponsibleUser
        {
            get { return GetValue<User>(); }
            set { SetValue(value); }
        }
    }
}
