using BasicCRM.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BasicCRM.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class , IEntity,new()
    {
        T Get(Expression<Func<T,bool>> fiter=null);

        T GetId(int id);

        List<T> GetList(Expression<Func<T, bool>> fiter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Remove(int id);

        void Edit(int id);
    }
}
