using Sinav.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DAL.Repositories.Interfaces
{
    public interface IBaseRepository <T> where T : BaseEntity
    {
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetAllWhere(Expression<Func<T, bool>> expression);
        public T GetById(int id);
        public bool Any(Expression<Func<T, bool>> expression);
    }
}
