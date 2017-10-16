using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBearKingdom.Models
{
    [Table("Product")]

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public float Origincountry { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
