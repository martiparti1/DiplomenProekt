using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Models.Product
{
    public class ProductIndexVM
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        public int MakerId { get; set; }
        [Display(Name ="Maker")]
        public string MakerName { get; set; }
        public int CategoryId { get; set; }
        [Display(Name ="Category")]
        public string CategoryName { get; set; }
        [Display(Name ="Image")]
        public string Image { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Platform")]
        public string Platform { get; set; }
       
        [Display(Name ="Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }
    }
}
