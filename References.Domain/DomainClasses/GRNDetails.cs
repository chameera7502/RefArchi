using System.ComponentModel.DataAnnotations;

namespace POS.Domain.DomainClasses
{
    public class GRNDetails
    {
        [Key]
        public int Id { get; set; }
        public int itemID { get; set; }
        public decimal qty { get; set; }
        public decimal BPrice { get; set; }
        public decimal lineDiscount { get; set; }

        public GRNHeader grnHeader { get; set; }

    }
}