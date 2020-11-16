using BasicCRM.Business.Abstract;
using BasicCRM.Business.Contants;
using BasicCRM.Core.Utilities;
using BasicCRM.Core.Utilities.Results;
using BasicCRM.DataAccess.Abstract;
using BasicCRM.DataAccess.Concrete.EntityFramework;
using BasicCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.Business.Concrete
{
   public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == userId));
        }

        public User GetByUserName(string userName)
        {
            return _userDal.Get(u => u.UserName == userName);
        }

        public User GeyByUserPassword(string userPassword)
        {
            return _userDal.Get(u => u.UserPassword == userPassword);
        }

        public IDataResult<User> Login(User user)
        {
            var userToCheck = GetByUserName(user.UserName);
            var userToCheckPassword = GeyByUserPassword(user.UserPassword);
            if (userToCheck==null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            if (Convert.ToInt32(userToCheckPassword.UserPassword) != Convert.ToInt32(user.UserPassword) )
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            return new SuccessDataResult<User>(userToCheck);
        }

        public IResult UserExits(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
