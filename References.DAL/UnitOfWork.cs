using POS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    public class UnitOfWork:IDisposable
    {
        private POSContext dbContext;
        
        public GenericRepository<TEntityType> GetRepository<TEntityType>() where TEntityType : class
        {
            return new GenericRepository<TEntityType>(dbContext);
        }

        public UnitOfWork(POSContext context)
        {
            this.dbContext = context;
            
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }
}
