using POS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain
{
    public class POSContext:DbContext
    {
        
            public POSContext() : base("name=PointOfSalesConnectionString")
            {
                 this.Configuration.LazyLoadingEnabled = false; 
            }

        public POSContext(bool EnableLazyLoading): base("name=PointOfSalesConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = EnableLazyLoading;
        }

            public DbSet<Item> Items { get; set; }
            public DbSet<Category> Category { get; set; }
        public DbSet<GRNDetails> GrnDetails { get; set; }
        public DbSet<GRNHeader> GrnHeaders { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public DbSet<Debtors> Debtors { get; set; }
        public DbSet<DebtorPayments> DebtorPayments { get; set; }
        public DbSet<CustomerMaster> CustomerMaster { get; set; }
        public DbSet<Test> Testdata { get; set; }



    }
}
