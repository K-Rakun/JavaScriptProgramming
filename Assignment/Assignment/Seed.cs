﻿using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AssignmentContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(

                    new Movie
                    {
                        Name = "Ghostbusters ",
                        ReleaseDate = new ReleaseDate { Year = 1984 }
                    },

                    new Movie
                    {
                        Name = "Ghostbusters 2",
                        ReleaseDate = new ReleaseDate { Year = 1986 }
                    },

                    new Movie
                    {
                        Name = "Rio Bravo",
                        ReleaseDate = new ReleaseDate { Year = 1959 }
                    }
                );
                context.SaveChanges();
            }
        }
        public static async Task SeedAdmin(UserManager<IdentityUser> userManager)
        {
            //Seed Default User
            var defaultUser = new IdentityUser
            {
                Email = "admin@gmail.com",
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password");
                }

            }
        }
    }
}
