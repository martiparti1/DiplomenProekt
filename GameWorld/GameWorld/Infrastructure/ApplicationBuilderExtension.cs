using GameWorld.Data;
using GameWorld.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebShopDemo.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;
            var cartMaker = services.GetRequiredService<ApplicationDbContext>();


            await RoleSeeder(services);
            await SeedAdministrator(services , cartMaker);

            var dataCategory = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedCategories(dataCategory);

            var dataMaker = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedMakers(dataMaker);

            

            return app;
        }

        public static async Task RoleSeeder(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Administrator", "Client" };

            IdentityResult roleResult;
            foreach (var role in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        public static async Task SeedAdministrator(IServiceProvider serviceProvider , ApplicationDbContext cartMaker)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            if (await userManager.FindByNameAsync("admin") == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.FirstName = "admin";
                user.LastName = "admin";
                user.PhoneNumber = "0888888888";
                user.Address = "admin";
                user.UserName = "admin";
                user.Email = "admin@admin.com";
                user.Balance = 10000;

                Cart adminCart = new Cart { UserId = user.Id };

                cartMaker.Carts.Add(adminCart);

                var result = await userManager.CreateAsync(user, "admin123");
                
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }

        public static void SeedCategories(ApplicationDbContext dataCategory)
        {
            if (dataCategory.Categories.Any())
            {
                return;
            }

            dataCategory.Categories.AddRange(new[]
            {
                new Category{CategoryName="Game"},
                new Category{CategoryName="DLC"},
                new Category{CategoryName="Accessory"},
                new Category{CategoryName="Console"},
                
            });
            dataCategory.SaveChanges();
        }

        public static void SeedMakers(ApplicationDbContext dataMaker)
        {
            if (dataMaker.Makers.Any())
            {
                return;
            }

            dataMaker.Makers.AddRange(new[]
            {
                new Maker{MakerName="Sony"},
                new Maker{MakerName="Nintendo"},
                new Maker{MakerName="Microsoft"},
                new Maker{MakerName="Bungie"},
                new Maker{MakerName="FromSoftware"},
                new Maker{MakerName="Atlus"},
                new Maker{MakerName="Ubisoft"},
                new Maker{MakerName="SquareEnix"},
                new Maker{MakerName="Razer"},
                new Maker{MakerName="Logitech"},
                new Maker{MakerName="SteelSeries"},
            });
            dataMaker.SaveChanges();
        }

        
        
    }
}
