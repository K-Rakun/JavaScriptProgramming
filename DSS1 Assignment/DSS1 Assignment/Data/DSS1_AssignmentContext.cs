#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DSS1_Assignment.Models;

namespace DSS1_Assignment.Data
{
    public class DSS1_AssignmentContext : DbContext
    {
        public DSS1_AssignmentContext (DbContextOptions<DSS1_AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<DSS1_Assignment.Models.Movie> Movie { get; set; }
    }
}
