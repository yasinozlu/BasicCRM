using BasicCRM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BasicCRM.Core.DataAccess.EntityFramework
{

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {
        protected readonly TContext _context;
        //public EfEntityRepositoryBase(TContext context)
        //{
        //    this._context = context;
        //}
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public TEntity GetId(int id)
        {
            using (var context = new TContext())
            {
                var entity = context.Set<TEntity>().Find(id);
                return entity;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
        public void Remove(int id)
        {
            using (var context = new TContext())
            {
                TEntity removedEntity = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(removedEntity);
                context.SaveChanges();
            }
        }


        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Edit(int id)
        {
            using (var context = new TContext())
            {
                TEntity editedEntity = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Update(editedEntity);
                context.SaveChanges();
            }
        }
    }
}
