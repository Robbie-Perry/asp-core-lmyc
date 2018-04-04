using asp_core_lmyc.Data;
using asp_core_lmyc.Models;
using LmycWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LmycWeb.Data
{
    public static class SeedData
    {
        public static void SeedBoats(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Boats.Any())
            {
                return;
            }

            List<Boat> boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatName = "Sharqui",
                    Picture = "http://www.lmyc.ca/sites/default/files/content/pages/sharqui%20photo.jpg",
                    LengthInFeet = 27,
                    Make = "C&C",
                    Year = 1981,
                    RecordCreationDate = new DateTime(),
                    ApplicationUserId = context.Users.FirstOrDefault(u => u.Email == "m@m.m").Id
                },
                new Boat()
                {
                    BoatName = "Pegasus",
                    Picture = "http://www.lmyc.ca/sites/default/files/content/pages/Small%20pegasus.jpg",
                    LengthInFeet = 27,
                    Make = "C&C",
                    Year = 1979,
                    RecordCreationDate = new DateTime(),
                    ApplicationUser = context.Users.FirstOrDefault(u => u.Email == "m@m.m")
                },
                new Boat()
                {
                    BoatName = "Frankie",
                    Picture = "http://www.lmyc.ca/sites/default/files/content/pages/frankie.jpg",
                    LengthInFeet = 25,
                    Make = "Cal Mark 2",
                    Year = 1983,
                    RecordCreationDate = new DateTime(),
                    ApplicationUser = context.Users.FirstOrDefault(u => u.Email == "m@m.m")
                },
            };
            foreach (Boat b in boats)
            {
                context.Boats.Add(b);
            }
            context.SaveChanges();
        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            IdentityResult result;
            if (userManager.FindByEmailAsync("a@a.a").Result == null)
            {
                ApplicationUser admin = new ApplicationUser()
                {
                    Email = "a@a.a",
                    UserName = "a@a.a",
                    FirstName = "aFirst",
                    LastName = "aLast",
                    Street = "aStreet",
                    City = "aCity",
                    Province = "aProvince",
                    PostalCode = "aPostalCode",
                    Country = "aCountry",
                    MobileNumber = "aMobile",
                    SailingExperience = "aExperience"
                };

                result = userManager.CreateAsync(admin, "P@$$w0rd").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, "Admin").Wait();
                }
            }
            if (userManager.FindByEmailAsync("m@m.m").Result == null)
            {
                ApplicationUser member = new ApplicationUser()
                {
                    Email = "m@m.m",
                    UserName = "m@m.m",
                    FirstName = "mFirst",
                    LastName = "mLast",
                    Street = "mStreet",
                    City = "mCity",
                    Province = "mProvince",
                    PostalCode = "mPostalCode",
                    Country = "mCountry",
                    MobileNumber = "mMobile",
                    SailingExperience = "mExperience"
                };
                result = userManager.CreateAsync(member, "P@$$w0rd").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(member, "Member").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Member").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Member";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
