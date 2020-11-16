using BasicCRM.Core.DataAccess.EntityFramework;
using BasicCRM.DataAccess.Abstract;
using BasicCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCRM.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, SqlContext>, IUserDal
    {
    }
}
