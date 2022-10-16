﻿using System.Linq.Expressions;

namespace MySchool.Data.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        TEntity FindFirstBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(int id);
        bool SaveChanges();
    }
}
