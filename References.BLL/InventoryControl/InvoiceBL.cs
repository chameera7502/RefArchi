using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain.DomainClasses;
using POS.DAL;

namespace POS.BLL.InventoryControl
{
    public class InvoiceBL : IInvoiceBL
    {
        UnitOfWork unitOfWork;
        public InvoiceBL()
        {
            this.unitOfWork = new UnitOfWork(new Domain.POSContext());
        }
        public InvoiceHeader GetInvoiceByID(int InvoiceID)
        {
            this.unitOfWork = new UnitOfWork(new Domain.POSContext(true));
            return this.unitOfWork.GetRepository<InvoiceHeader>().FirstOrDefalult(InvoiceID);
        }

        public InvoiceHeader GetInvoiceByInvoiceCode(string InvoiceCode)
        {
            var invoiceHeader = this.unitOfWork.GetRepository<InvoiceHeader>().List.
                Where(c => c.invoiceCode.Equals(InvoiceCode));
            return invoiceHeader.FirstOrDefault();
                                
        }

        public IEnumerable<InvoiceHeader> InvoiceList()
        {
            return this.unitOfWork.GetRepository<InvoiceHeader>().List;
        }

        public IEnumerable<InvoiceHeader> InvoiceList(string InvoiceCode)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Save changes to invoice
        /// </summary>
        /// <param name="header"></param>
        /// <param name="details"></param>
        public void SaveInvoice(InvoiceHeader header, IList<InvoiceDetails> details)
        {
            if (header.invoiceID==-1)//Save
            {
                this.unitOfWork.GetRepository<InvoiceHeader>().Add(header);
                foreach (var invoiceDetail in details)
                {
                    this.unitOfWork.GetRepository<InvoiceDetails>().Add(invoiceDetail);
                }

            }
            else//update
            {
                this.unitOfWork.GetRepository<InvoiceHeader>().Update(header);
                foreach (var invoiceDetail in details)
                {
                    this.unitOfWork.GetRepository<InvoiceDetails>().Update(invoiceDetail);
                }
            }

            this.unitOfWork.Commit();
        }
    }
}
