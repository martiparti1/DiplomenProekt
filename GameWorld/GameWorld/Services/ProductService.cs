using GameWorld.Abstraction;
using GameWorld.Data;
using GameWorld.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        { _context = context; }

        public bool Create(string name, int makerId, int categoryId, string image, string description, string platform, int quantity, decimal price, decimal discount)
        {
            Product item = new Product
            {
                ProductName = name,
                Maker = _context.Makers.Find(makerId),
                Category = _context.Categories.Find(categoryId),
                Image = image,
                Description = description,
                Platform = platform,
                Quantity = quantity,
                Price = price,
                Discount = discount
            };
            _context.Products.Add(item);
            return _context.SaveChanges() != 0;
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public List<Product> GetProducts()
        {
            List<Product> products = _context.Products.ToList();
                return products;
        }
        public bool RemoveById(int productId)
        {
            var product = GetProductById(productId);
            if(product==default(Product))
            { return false; }

            _context.Remove(product);
            return _context.SaveChanges() != 0;
        }
        public List<Product> GetProducts(string searchStringCategoryName, string searchStringMakerName)
        {
            List<Product> products = _context.Products.ToList();

            if (!String.IsNullOrEmpty(searchStringCategoryName) && !String.IsNullOrEmpty(searchStringMakerName))
            {
                products = products.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())
                && x.Maker.MakerName.ToLower().Contains(searchStringMakerName)).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringCategoryName))
            {
                products = products.Where(x => x.Category.CategoryName.ToLower().Contains(searchStringCategoryName.ToLower())).ToList();
            }
            else if (!String.IsNullOrEmpty(searchStringMakerName))
            {
                products = products.Where(x => x.Maker.MakerName.ToLower().Contains(searchStringMakerName)).ToList();
            }

            return products;

        }

        public bool Update(int productId, string name, int makerId, int categoryId, string image, string description, string platform, int quantity, decimal price, decimal discount)
        {
            var product = GetProductById(productId);
            if (product==default(Product))
            { return false; }

            product.ProductName = name;
            product.Maker = _context.Makers.Find(makerId);
            product.Category = _context.Categories.Find(categoryId);
            product.Image = image;
            product.Description = description;
            product.Platform = platform;
            product.Quantity = quantity;
            product.Price = price;
            product.Discount = discount;
            _context.Update(product);
            return _context.SaveChanges() != 0;
        }
    }
}
