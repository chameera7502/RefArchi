using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class Category
    {
        [Key]
        public int CatID { get; set; }
        public string CategoryName { get; set; }
        public bool isActive { get; set; }

        public ICollection<Item> items { get; set; }

    }
}
