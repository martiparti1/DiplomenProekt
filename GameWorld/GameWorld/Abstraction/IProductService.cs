using GameWorld.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Abstraction
{
    public interface IProductService
    {
        bool Create(string name, int makerId, int categoryId, string image,
            string description, string platform, int quantity, decimal price, decimal discount);

        bool Update(int productId,string name, int makerId, int categoryId, string image,
            string description, string platform, int quantity, decimal price, decimal discount);

        List<Product> GetProducts();
        Product GetProductById(int productId);
        bool RemoveById(int productId);
        List<Product> GetProducts(string searchStringCategoryName, string searchStringBrandName);

    }
}
