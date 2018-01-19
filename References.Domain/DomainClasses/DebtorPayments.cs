using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class DebtorPayments
    {
        public int id { get; set; }
        
        public DateTime paidDate { get; set; }
       
        public decimal paidAmount { get; set; }

        public Debtors Debtor { get; set; }
        //public InvoiceHeader Invoice { get; set; }
    }
}
