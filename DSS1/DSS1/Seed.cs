using DSS1.Data;
using DSS1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AssignmentDSS
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DSS1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DSS1Context>>()))
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

        /*public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole("admin"));
        }*/

        public static async Task SeedAdmin(UserManager<IdentityUser> userManager)
        {
            //Seed Default User
            var defaultUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password1!");
                    await userManager.AddToRoleAsync(defaultUser, "admin");
                }

            }
        }
    }
}
