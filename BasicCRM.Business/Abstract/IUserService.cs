using BasicCRM.Core.Utilities;
using BasicCRM.Core.Utilities.Results;
using BasicCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.Business.Abstract
{
   public interface IUserService
    {
        IDataResult<User> GetById(int userId);

        IDataResult<User> Login(User user);

        IResult UserExits(string userName);

        User GetByUserName(string userName);

        User GeyByUserPassword(string userPassword);
    }
}
