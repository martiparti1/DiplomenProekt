using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Domain
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        
        public string ProductName { get; set; }

        [Required]
        public int MakerId { get; set; }
        public virtual Maker Maker { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        [Required]
        [Range(0,5000)]
        public int Quantity { get; set; }
        [Required]
        [Range(0,5000)]
        public decimal Price { get; set; }
        [Range(0,100)]
        public decimal Discount { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; } = new List<Order>();

    }
}
