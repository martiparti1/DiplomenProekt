using GameWorld.Abstraction;
using GameWorld.Data;
using GameWorld.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace GameWorld.Controllers
{
    public class CartController : Controller
    {
        //this is the cart controller

        private readonly IProductService _productService;
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context, IProductService productService)
        {
            this._context = context;
            this._productService = productService;
        }


        public IActionResult Index()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);

            return View(cart);
        }

        public ActionResult AddToCart(int productId, int quantity)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);
            var product = this._context.Products.SingleOrDefault(p => p.Id == productId);

            if (cart == null || user == null) { return NotFound(); }

            var cartItem = new CartItem
            {
                Product = product,
                Quantity = quantity
            };

            if (!cart.Items.Contains(cartItem))
            {
                cart.Items.Add(cartItem);
            }

            else
            {
                var index = cart.Items.IndexOf(cartItem);
                cart.Items[index].Quantity++;
            }
            this._context.SaveChanges();
            return RedirectToAction("Index", "Cart");
        }




        public ActionResult RemoveFromCart(int productId)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);
            var product = this._context.Products.SingleOrDefault(p => p.Id == productId);

            if (cart == null || user == null) return null;

            var cartItem = new CartItem
            {
                Product = product
            };
            cart.Items.Remove(cartItem);

            this._context.SaveChanges();
            return RedirectToAction("Index" , "Cart");
        }

        public ActionResult ClearCart()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);

            List<CartItem> items2remove = new List<CartItem>();

            foreach (var item in cart.Items)
            {
                items2remove.Add(item);
            }

            foreach (var item in items2remove)
            {
                cart.Items.Remove(item);
            }

            this._context.SaveChanges();
            return RedirectToAction("Index", "Cart");
        }

        // [HttpPost]
        public ActionResult Checkout()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);

            if (user == null) return null;

            decimal cartTotal = 0;

            foreach (var item in cart.Items)
            {
                cartTotal += item.Quantity * item.Product.Price - item.Quantity * item.Product.Price * item.Product.Discount / 100;
            }

            if (user.Balance >= cartTotal)
            {
                List<CartItem> items2remove = new List<CartItem>();
                foreach (var item in cart.Items)
                {
                    var currentProduct = this._context.Products.SingleOrDefault(p => p.Id == item.Product.Id);
                    Order orderForDb = new Order
                    {
                        OrderDate = DateTime.UtcNow,
                        ProductId = item.Product.Id,
                        UserId = userId,
                        Quantity = item.Quantity,
                        Price = item.Product.Price,
                        Discount = item.Product.Discount
                    };
                    currentProduct.Quantity -= item.Quantity;
                    this._context.Products.Update(currentProduct);
                    this._context.Orders.Add(orderForDb);

                    items2remove.Add(item);
                }

                foreach (var item in items2remove)
                {
                    cart.Items.Remove(item);
                }
                user.Balance -= cartTotal;
            }
            else
            {
                return this.RedirectToAction("NotEnoughBal", "Product");
            }

            this._context.SaveChanges();
            return RedirectToAction("ThanksForBuying", "Order");
        }

        public IActionResult UpdateCart(int productId, int newQuantity)
        {
            if (newQuantity < 0)
            {
                return BadRequest("Invalid quantity value.");
            }

            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);
            var product = this._context.Products.SingleOrDefault(p => p.Id == productId);

            if (cart == null)
            {
                return NotFound("Cart not found.");
            }

            var cartItem = new CartItem
            {
                Product = product
            };


            if (newQuantity == 0)
            {
                cart.Items.Remove(cartItem);
            }
            else
            {
                cartItem.Quantity = newQuantity;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cart");
        }
    }
    /*
     public ActionResult UpdateCart(int productId, int quantity, int newQuantity) 
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            var cart = _context.Carts.SingleOrDefault(c => c.UserId == userId);
            var product = this._context.Products.SingleOrDefault(p => p.Id == productId);

            if (cart == null || user == null) return null;

            

            return View(cart);
        }*/

}