﻿using GameWorld.Models.Client;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameWorld.Domain;
using Microsoft.AspNetCore.Authorization;

namespace WebShopDemo.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ClientController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public ClientController(UserManager<ApplicationUser> userManager)
        { this.userManager = userManager; }

        public async Task<IActionResult> Index()
        {
            var allUsers = this.userManager.Users
                .Select(u => new ClientIndexVM
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Address = u.Address,
                    PhoneNumber = u.PhoneNumber,
                    Email = u.Email
                }).ToList();

            var adminIds = (await this.userManager.GetUsersInRoleAsync("Administrator"))
                .Select(a => a.Id).ToList();
            foreach (var user in allUsers)
            {
                user.IsAdmin = adminIds.Contains(user.Id);
            }

            var users = allUsers.Where(x => x.IsAdmin == false)
                .OrderBy(x => x.UserName).ToList();

            return this.View(users);
        }

        public ActionResult Delete(string id)
        {
            var user = this.userManager.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            { return NotFound(); }

            ClientDeleteVM userToDelete = new ClientDeleteVM()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                UserName = user.UserName
            };
            return View(userToDelete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ClientDeleteVM bindingModel)
        {
            string id = bindingModel.Id;
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            { return NotFound(); }

            else
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                { return RedirectToAction("SuccessDeleteUser"); }
                else { return NotFound(); }
            }
        }
        public ActionResult SuccessDeleteUser()
        { return View(); }
    }
}