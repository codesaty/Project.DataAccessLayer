using Microsoft.EntityFrameworkCore;
using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Project.Core.DataAcces.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var contextType = new TContext())
            {
                var added = contextType.Entry(entity);
                added.State = EntityState.Added;
                contextType.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var contextType = new TContext())
            {
                var deleted = contextType.Entry(entity);
                deleted.State = EntityState.Deleted;
                contextType.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var contextType = new TContext())
            {
                return filter == null ? contextType.Set<TEntity>().ToList() : contextType.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (var contextType = new TContext())
            {
                var updated = contextType.Entry(entity);
                updated.State = EntityState.Modified;
                contextType.SaveChanges();
            }
        }
    }
}
