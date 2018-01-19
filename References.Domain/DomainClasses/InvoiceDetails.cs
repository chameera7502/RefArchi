using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class InvoiceDetails
    {
        [Key]
        public int id { get; set; }
        public int itemId { get; set; }
        public decimal qty { get; set; }
        public decimal sPrice { get; set; }
        public decimal lineDiscount { get; set; }

        public InvoiceHeader invoiceHeader { get; set; }


    }
}
