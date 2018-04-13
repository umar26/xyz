using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Model;
namespace OnlineExam.DAL
{
   public class Repository<T> : IRepository<T> where T : class
    {
        public OnlineExamEntities _context;
        public Repository()
        {
            this._context = new OnlineExamEntities();

        }
        public T Add(T entity)
        {
           return _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
