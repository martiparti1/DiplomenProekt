using GameWorld.Models.Client;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameWorld.Domain;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using GameWorld.Data;
using GameWorld.Models.Balance;

namespace GameWorld.Controllers
{
    public class BalanceController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public BalanceController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            this._userManager = userManager;
            this._context = context;
        }
        public IActionResult Index()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);

            var balance = user.Balance;
            return View();
        }

        public ActionResult Create()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);
            
            

            if(user==null)
            { return NotFound(); }

            BalanceAddVM updatedBalance = new BalanceAddVM
            {
                UserId = user.Id,
                UserName=user.UserName,
                UserBalance = user.Balance
            };

            return View(updatedBalance);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BalanceAddVM balanceAddVM)
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.SingleOrDefault(u => u.Id == userId);



            if (user == null)
            { return NotFound(); }

            BalanceAddVM updatedBalance = new BalanceAddVM
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserBalance = user.Balance,
                AddBalance=balanceAddVM.AddBalance

                
            };

            return View(updatedBalance);
        }
    }
}
