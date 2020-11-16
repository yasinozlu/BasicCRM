using BasicCRM.Core.DataAccess.EntityFramework;
using BasicCRM.DataAccess.Abstract;
using BasicCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BasicCRM.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, SqlContext>, ICustomerDal
    {
        //public efcustomerdal(sqlcontext context) : base(context)
        //{

        //}


        //public Customer GetCustomerDetailsById(int customerId)
        //{
        //    using (var context = new SqlContext())
        //    {
        //        return context.SpGetCustomerById.FromSqlRaw($"spGetCustomerById {customerId}").FirstOrDefault();
        //    }
        //}
      
    }
}
