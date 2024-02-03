using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using var value = new TContext();
            value.Remove(entity);
            value.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var value = new TContext();
            value.Add(entity);
            value.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            using var value = new TContext();
            return value.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            using var value = new TContext();
            return value.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            using var value = new TContext();
            value.Update(entity);
            value.SaveChanges();
        }
    }
}
