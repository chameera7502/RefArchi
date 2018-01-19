
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class Item
    {
        [Key]
        public int itemId { get; set; }
       
        public string itemName { get; set; }
        public decimal ROL { get; set; }
        public decimal Qty { get; set; }
        public decimal salesPrice { get; set; }
        public decimal purchasePrice { get; set; }

        public int category_CatID { get; set; }

        [ForeignKey("category_CatID")]
        public Category category { get; set; }


    }
}
