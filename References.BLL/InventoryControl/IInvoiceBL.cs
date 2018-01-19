using POS.Domain.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.InventoryControl
{
    public interface IInvoiceBL
    {
        void SaveInvoice(InvoiceHeader header, IList<InvoiceDetails> details);
        IEnumerable<InvoiceHeader> InvoiceList();
        InvoiceHeader GetInvoiceByID(int InvoiceID);
        InvoiceHeader GetInvoiceByInvoiceCode(string InvoiceCode);
        /// <summary>
        /// Search Invoice List for the given part of text in invoiceCode
        /// </summary>
        /// <param name="InvoiceCode"></param>
        /// <returns></returns>
        IEnumerable<InvoiceHeader> InvoiceList(string InvoiceCode);
    }
}
