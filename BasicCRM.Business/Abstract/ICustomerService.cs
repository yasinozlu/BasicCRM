using BasicCRM.Core.Utilities;
using BasicCRM.Core.Utilities.Results;
using BasicCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int customerId);
        //Stored Proc
        //IDataResult<Customer> GetCustomerDetailById(int customerId);
        IDataResult<List<Customer>> GetList();
        IResult Add(Customer customer);
        IResult Delete(int customerId);
        IResult Edit(int customerId);
        IResult Update(Customer customer);



    }
}
