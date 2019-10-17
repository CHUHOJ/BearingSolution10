using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class DayOffWrapper : ModelWrapper<DayOff>
    {
        public DayOffWrapper(DayOff model) : base(model) { }

        public int DayOffID { get { return Model.DayOffID; } }

        public string UserID
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public DateTime Date
        {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }

        public string Type
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public User User
        {
            get { return GetValue<User>(); }
            set { SetValue(value); }
        }

    }
}
