﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Domain
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public string Description { get; set; }

        [Required]
        public int Quantity { get; set; }
        
        [Required]
        [Range(0,5000)]
        public decimal Price { get; set; }
        [Required]
        [Range(0,100)]
        public decimal Discount { get; set; }
        public decimal FinalPrice
        {
            get 
            {
                return Quantity * Price - Quantity * Price * Discount / 100;
            }
        }
    }
}
