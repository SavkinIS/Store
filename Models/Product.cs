using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Product
    {
        [Required]
        public Guid ID { get; set; }

        [StringLength(12)]
        [Required]
        [RegularExpression(@"^\d{2}-\d{4}-[A-Z]{2}\d{2}")]
        public string CODE { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public int PRICE { get; set; }
        [Required]
        public string CATEGORY { get; set; }
    }
}
