using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class UserWrapper : ModelWrapper<User>
    {
        public UserWrapper(User model) : base(model) { }

        public int UserID { get { return Model.UserID; } }

        public string ShortAlias
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string FullName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Role
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Department
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

    }
}
