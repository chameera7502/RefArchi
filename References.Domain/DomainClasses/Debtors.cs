using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class Debtors
    {
        [Key]
        public int id { get; set; }
        
        public DateTime DebitDate { get; set; }
        public decimal debitAmount { get; set; }
        
        public bool isPaid { get; set; }

        public CustomerMaster Customer { get; set; }
        public ICollection<DebtorPayments> debtorPayments { get; set; }

    }
}
