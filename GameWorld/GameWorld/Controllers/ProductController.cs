using GameWorld.Abstraction;
using GameWorld.Domain;
using GameWorld.Models.Category;
using GameWorld.Models.Maker;
using GameWorld.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameWorld.Controllers
{
    [Authorize(Roles ="Administrator")]
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
                    Name = x.MakerName
                }).ToList();
            product.Categories = _categoryService.GetCategories()
                .Select(x => new CategoryPairVM()
                {
                    Id = x.Id,
                    Name = x.CategoryName
                }).ToList();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] ProductCreateVM product)
        {
            if (ModelState.IsValid)
            {
                var createdId = _productService.Create(product.ProductName, product.MakerId, product.CategoryId,
                    product.Image, product.Description, product.Platform, product.Quantity, product.Price, product.Discount);

                if (createdId)
                { return this.RedirectToAction("CreateSuccess"); }
            }
            return View();
        }
        public IActionResult CreateSuccess()
        { return this.View(); }
        [Authorize(Roles = "Client")]
        public IActionResult NotEnoughBal()
        { return this.View(); }

        [AllowAnonymous]
        public ActionResult Index(string searchStringCategoryName, string searchStringPlatformName)
        {
            List<ProductIndexVM> products = _productService.GetProducts(searchStringCategoryName, searchStringPlatformName)
                .Select(product => new ProductIndexVM
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    MakerId = product.MakerId,
                    MakerName = product.Maker.MakerName,
                    CategoryId = product.CategoryId,
                    CategoryName = product.Category.CategoryName,
                    Image = product.Image,
                    Description = product.Description,
                    Platform = product.Platform,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    Discount = product.Discount

                }).ToList();
            return this.View(products);
        }

        public ActionResult Edit(int id)
        {
            Product product = _productService.GetProductById(id);
            if (product == null)
            { return NotFound(); }

            ProductEditVM updatedProduct = new ProductEditVM()
            {

                Id = product.Id,
                ProductName = product.ProductName,
                MakerId = product.MakerId,
                CategoryId = product.CategoryId,
                Image = product.Image,
                Description = product.Description,
                Platform = product.Platform,
                Quantity = product.Quantity,
                Price = product.Price,
                Discount = product.Discount
            };

            updatedProduct.Makers = _makerService.GetMakers()
                .Select(m => new MakerPairVM()
                {
                    Id = m.Id,
                    Name = m.MakerName
                }).ToList();

            updatedProduct.Categories = _categoryService.GetCategories()
                .Select(c => new CategoryPairVM
                {
                    Id = c.Id,
                    Name = c.CategoryName
                }).ToList();

            return View(updatedProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id, ProductEditVM product)
        {
            if (ModelState.IsValid)
            {
                var updated = _productService.Update(id, product.ProductName, product.MakerId,
                    product.CategoryId, product.Image, product.Description, product.Platform,
                    product.Quantity, product.Price, product.Discount);

                if (updated)
                { return this.RedirectToAction("Index"); }

            }
            return View(product);
        }

        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            Product item = _productService.GetProductById(id);
            if (item == null)
            { return NotFound(); }

            ProductDetailsVM product = new ProductDetailsVM()
            {
                Id = item.Id,
                ProductName = item.ProductName,
                MakerId = item.MakerId,
                MakerName = item.Maker.MakerName,
                CategoryId = item.CategoryId,
                CategoryName = item.Category.CategoryName,
                Image = item.Image,
                Description = item.Description,
                Platform = item.Platform,
                Quantity = item.Quantity,
                Price = item.Price,
                Discount = item.Discount
            };
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            Product item = _productService.GetProductById(id);
            if (item == null)
            { return NotFound(); }

            ProductDeleteVM product = new ProductDeleteVM()
            {
                Id = item.Id,
                ProductName = item.ProductName,
                MakerId = item.MakerId,
                MakerName = item.Maker.MakerName,
                CategoryId = item.CategoryId,
                CategoryName = item.Category.CategoryName,
                Image = item.Image,
                Description = item.Description,
                Platform = item.Platform,
                Quantity = item.Quantity,
                Price = item.Price,
                Discount = item.Discount
            };
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _productService.RemoveById(id);
            if (deleted)
            { return this.RedirectToAction("DeleteSuccess"); }
            else { return View(); }
        }

        public IActionResult DeleteSuccess()
        { return View(); }
    }
}
