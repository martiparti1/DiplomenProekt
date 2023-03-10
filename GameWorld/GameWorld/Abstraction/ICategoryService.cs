using GameWorld.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategoriesById(int categoryId);
        List<Product> GetProductsByCategory(int categoryId);
    }
}
