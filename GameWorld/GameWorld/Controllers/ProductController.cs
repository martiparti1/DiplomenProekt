using GameWorld.Abstraction;
using GameWorld.Models.Category;
using GameWorld.Models.Maker;
using GameWorld.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMakerService _makerService;

        public ProductController(IProductService productService, ICategoryService categoryService, IMakerService makerService)
        {
            this._productService = productService;
            this._categoryService = categoryService;
            this._makerService = makerService;
        }

        public ActionResult Create()
        {
            var product = new ProductCreateVM();
            product.Makers = _makerService.GetMakers()
                .Select(x => new MakerPairVM()
                {
                    Id = x.Id,
                    Name= x.MakerName
                }).ToList();
            product.Categories = _categoryService.GetCategories()
                .Select(x => new CategoryPairVM()
                {
                    Id=x.Id,
                    Name = x.CategoryName
                }).ToList();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] ProductCreateVM product)
        {
            if(ModelState.IsValid)
            {
                var createdId = _productService.Create(product.ProductName, product.MakerId, product.CategoryId,
                    product.Image, product.Description, product.Platform, product.Quantity, product.Price, product.Discount);

                if(createdId)
                { return RedirectToAction(nameof(Index)); }
            }
            return View();
        }
    }
}
