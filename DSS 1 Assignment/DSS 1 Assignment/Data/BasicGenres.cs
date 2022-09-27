using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DSS_1_Assignment.Data;
using System;
using System.Linq;

namespace DSS_1_Assignment.Models
{
    public static class BasicGenres
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DSS_1_AssignmentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DSS_1_AssignmentContext>>()))
            {
                
                if (context.Genre.Any())
                {
                    return;   
                }

                context.Genre.AddRange(
                    new DSS_1_Assignment.Models.Genre
                    {
                        Name = "Comedy"
                    },

                    new DSS_1_Assignment.Models.Genre
                    {
                        Name = "Horror"
                    },

                    new DSS_1_Assignment.Models.Genre
                    {
                        Name = "Action"
                    },

                    new DSS_1_Assignment.Models.Genre
                    {
                        Name = "Romance"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}