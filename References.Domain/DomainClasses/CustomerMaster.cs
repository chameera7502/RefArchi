using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class CustomerMaster
    {
        [Key]
        public int customerID { get; set; }
        public string contactNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Debtors> Debtors { get; set; }
        public ICollection<DebtorPayments> DebtorPayments { get; set; }


    }
}
