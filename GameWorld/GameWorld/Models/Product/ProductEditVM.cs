using GameWorld.Models.Category;
using GameWorld.Models.Maker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Models.Product
{
    public class ProductEditVM
    {
        public ProductEditVM()
        {
            Makers = new List<MakerPairVM>();
            Categories = new List<CategoryPairVM>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name ="Maker")]
        public int MakerId { get; set; }
        public virtual List<MakerPairVM> Makers { get; set; }
        [Required]
        [Display(Name ="Category")]
        public int CategoryId { get; set; }
        public virtual List<CategoryPairVM> Categories { get; set; }

        [Display(Name ="Image")]
        public string Image { get; set; }
        
        [Display(Name ="Description")]
        public string Description { get; set; }
        [Display(Name ="Platform")]
        public string Platform { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }
    }
}
