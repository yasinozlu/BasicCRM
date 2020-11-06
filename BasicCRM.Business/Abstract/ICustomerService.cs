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
        IDataResult<List<Customer>> GetList();
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);

    }
}
