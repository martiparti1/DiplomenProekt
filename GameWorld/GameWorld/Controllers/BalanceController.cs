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

namespace GameWorld.Controllers
{
    public class BalanceController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public BalanceController(UserManager<ApplicationUser> userManager)
        { _userManager = userManager; }
        public IActionResult AddBalance()
        { return View(); }
        [HttpPost]
        public async Task<IActionResult> AddBalance(decimal amount)
        {
            var user = await _userManager.GetUserAsync(User);
            user.Balance += amount;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Home");
        }
    }
}
