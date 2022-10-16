using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using MySchool.Data.Interfaces;

namespace MySchool.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ApplicationDbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public TEntity FindFirstBy(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = DbSet.Where(predicate).AsQueryable();
            return query;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable<TEntity>();
        }


        public virtual void Update(TEntity obj)
        {
            var a = Db.ChangeTracker.Entries().GroupBy(x => x.State);
            DbSet.Update(obj);
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public bool SaveChanges()
        {
            try
            {
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

            return true;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public void BeginTransaction()
        {
            Db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            Db.Database.CommitTransaction();
        }
    }
}
