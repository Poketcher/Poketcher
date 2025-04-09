using System.Collections;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Poketcher.database.DBContext;
using Poketcher.database.Entities;

namespace Poketcher.database.Repositories.Base;

public class Repository<T> : IRepository<T> where T : class, IBaseEntity
{
    public UserDbContext _context { get; }
    private DbSet<T> _dbSet;

    public Repository(UserDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public DbSet<T> Set => _dbSet ??= _context.Set<T>();

    public IQueryable<T> Exist(int id, string errorMessage)
    {
        var entities = GetById(id);

        if (entities.Count() == 0)
            throw new Exception(errorMessage);

        return entities;
    }

    public T Add(T entity)
    {
        var result = _context.Set<T>().Add(entity);
        return result.Entity;
    }

    public void Delete(T entity) =>
        _context.Remove(entity);

    public IQueryable<T> FindAll(Expression<Func<T, bool>> expression) =>
        _dbSet.AsQueryable().Where(expression);

    public IQueryable<T> GetAll() =>
        _dbSet;

    public IQueryable<T> GetById(int id) =>
         _dbSet.Where(x => x.Id == id);

    public T Update(T entity)
    {
        _context.Set<T>().Update(entity);
        return entity;
    }

    public bool SaveChanges() =>
         _context.SaveChanges() >= 0;

    #region Implementation of Enumerable and IQuerable
    public IEnumerator<T> GetEnumerator()
    {
        return Set.AsQueryable().AsEnumerable().GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Type ElementType
    {
        get { return (Set.AsQueryable() as IQueryable).ElementType; }
    }

    public Expression Expression
    {
        get { return (Set.AsQueryable() as IQueryable).Expression; }
    }

    public IQueryProvider Provider
    {
        get { return (Set.AsQueryable() as IQueryable).Provider; }
    }
    #endregion
}