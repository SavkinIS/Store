using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Customer
    {
        public Guid ID { get; set; }

        /// <summary>
        /// Код заказчика. Содержит данные формата «ХХХХ-ГГГГ» где Х – число, ГГГГ – год в котором зарегистрирован заказчик. Не пустое.
        /// </summary>
        [StringLength(8)]
        [Required]
        [RegularExpression(@"^\d{4}-20[1-9][0-9]")]
        public string CODE { get; set; }
        public string NAME { get; set; }

        public string ADDRESS { get; set; }

        public int? DISCOUNT { get; set; }
    }
}
