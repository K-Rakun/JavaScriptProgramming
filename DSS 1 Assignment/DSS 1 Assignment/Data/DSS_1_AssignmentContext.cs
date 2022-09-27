#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DSS_1_Assignment.Models;

namespace DSS_1_Assignment.Data
{
    public class DSS_1_AssignmentContext : DbContext
    {
        public DSS_1_AssignmentContext (DbContextOptions<DSS_1_AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<DSS_1_Assignment.Models.Movie> Movie { get; set; }

        public DbSet<DSS_1_Assignment.Models.Genre> Genre { get; set; }

        public DbSet<DSS_1_Assignment.Models.ReleaseDate> ReleaseDate { get; set; }

    }
}
