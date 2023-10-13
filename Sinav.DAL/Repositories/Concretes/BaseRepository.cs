using Microsoft.EntityFrameworkCore;
using Sinav.Core.Abstracts;
using Sinav.Core.Enums;
using Sinav.DAL.Context;
using Sinav.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DAL.Repositories.Concretes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext dbContext;
        protected DbSet<T> table;

        public BaseRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            table = dbContext.Set<T>();
        }

        public bool Add(T entity)
        {
            table.Add(entity);
            return dbContext.SaveChanges() > 0;
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return table.Any(expression);
        }

        public bool Delete(T entity)
        {
            entity.DeleteDate = DateTime.Now;
            entity.Status = Status.Passive;
            table.Update(entity);
            return dbContext.SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
            return table.Where(x => x.Status != Status.Passive).ToList();
        }

        public IEnumerable<T> GetAllWhere(Expression<Func<T, bool>> expression)
        {
            return table.Where(expression).Where(x => x.Status != Status.Passive).ToList();
        }

        public T GetById(int id)
        {
            return table.FirstOrDefault(x => x.Id == id && x.Status != Status.Passive);
        }

        public bool Update(T entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.Status = Status.Modified;
            table.Update(entity);
            return dbContext.SaveChanges() > 0;
        }
    }
}
