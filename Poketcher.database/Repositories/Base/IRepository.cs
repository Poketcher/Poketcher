using System.Linq.Expressions;
using Poketcher.database.Entities;

namespace Poketcher.database.Repositories.Base
{
    public interface IRepository<T> : IQueryable<T> where T : IBaseEntity
    {
        public IQueryable<T> Exist(int id, string errorMessage);
        public T Add(T entity);
        public void Delete(T entity);
        public IQueryable<T> GetAll();
        public IQueryable<T> FindAll(Expression<Func<T, bool>> expression);
        public IQueryable<T> GetById(int id);
        public T Update(T entity);
        public bool SaveChanges();

    }
}
