using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class InvoiceHeader
    {
        [Key]
        public int invoiceID { get; set; }
        public string invoiceCode { get; set; }
        public DateTime invoiceDate { get; set; }
        public string narration { get; set; }

        public ICollection<InvoiceDetails> invoiceDetails { get; set; }
    }
}
