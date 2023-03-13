using GameWorld.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GameWorld.Models.Product;

namespace GameWorld.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameWorld.Models.Product.ProductCreateVM> ProductCreateVM { get; set; }
        public DbSet<GameWorld.Models.Product.ProductIndexVM> ProductIndexVM { get; set; }
        
    }
}
