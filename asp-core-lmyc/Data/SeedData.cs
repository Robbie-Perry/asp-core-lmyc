using asp_core_lmyc.Data;
using LmycWeb.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LmycWeb.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
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
    }
}
