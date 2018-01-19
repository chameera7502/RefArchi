using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.DomainClasses
{
    public class GRNHeader
    {
        [Key]
        public int GRNId { get; set; }
        public string GRNNumber { get; set; }
        public DateTime GRNDate { get; set; }
        public string narration { get; set; }

        public ICollection<GRNDetails> GRNDetails { get; set; }

    }
}
