using BasicCRM.Core.DataAccess;
using BasicCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        //Customer GetCustomerDetailsById(int customerId);
       
    }
}
