using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;
using BearingSolution10.WorkManager.Data;

namespace BearingSolution10.WorkManager.ViewModels
{
    public class CustomerWrapper : ModelWrapper<Customer>
    {
        public CustomerWrapper(Customer model) : base(model) { }

        public int CustomerID { get { return Model.CustomerID; } }

        public string CustomerName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

    }
}
