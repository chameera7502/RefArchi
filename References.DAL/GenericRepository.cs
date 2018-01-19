using POS.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POS.DAL
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> dbSet;
        private POSContext dbContext;
        public GenericRepository(POSContext context)
        {
            dbContext = context;
           dbSet= dbContext.Set<TEntity>();
        }
        public IEnumerable<TEntity> List
        {
            get
            {
                return dbSet.ToList();
            }
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            if (dbContext.Entry(entity).State==EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public TEntity FirstOrDefalult(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State= System.Data.Entity.EntityState.Modified;
        }
    }
}
