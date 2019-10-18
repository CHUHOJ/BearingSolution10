using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using BearingSolution10.Infrastructure.Base;




namespace BearingSolution10.WorkManager.Data
{
    public class CustomerRepository : GenericRepository<Customer,WorkEntity >, ICustomerRepository
    {
        public CustomerRepository(WorkEntity context):base(context)
        {

        }

    }
}
