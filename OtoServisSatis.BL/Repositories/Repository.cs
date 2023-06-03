using OtoServisSatis.DAL;
using OtoServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.BL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class,IEntity, new()
    {
        private DatabaseContext context;
        private DbSet<T> dbSet;
        public Repository()
        {
            if (context == null)
            {
                context = new DatabaseContext();
                dbSet = context.Set<T>();
            }
        }

        public int Add(T entity)
        {
            dbSet.Add(entity);
            return Save();
        }

        public int Delete(int id)
        {
            dbSet.Remove(Find(id));
            return Save();
        }

        public T Find(int id)
        {
            return dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return dbSet.FirstOrDefault(expression);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).ToList();
        }

        public IQueryable<T> GetAllByInclude(string table)
        {
            return dbSet.Include(table);
        }

        public int Update(T entity)
        {
            dbSet.AddOrUpdate(entity);
            return Save();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        
    }
}
