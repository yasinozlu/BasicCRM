using BasicCRM.Business.Abstract;
using BasicCRM.Business.Contants;
using BasicCRM.Core.Utilities;
using BasicCRM.Core.Utilities.Results;
using BasicCRM.DataAccess.Abstract;
using BasicCRM.DataAccess.Concrete.EntityFramework;
using BasicCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCRM.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.CustomerId == customerId));
        }

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList().ToList());
        }
        public IResult Add(Customer customer)
        {
            //Business Codes
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
