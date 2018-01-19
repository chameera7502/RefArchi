using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DTO
{
    public class ItemDto
    {
        public int itemId { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal lineDisc { get; set; }

    }
}
