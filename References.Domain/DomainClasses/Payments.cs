
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class Payments
    {
        [Key]
        public int paymentId { get; set; }
        
        public decimal BillTotal { get; set; }
        public string paymentMode { get; set; }
        public decimal paidAmount { get; set; }

        public InvoiceHeader InvoiceHeade { get; set; }
    }
}
