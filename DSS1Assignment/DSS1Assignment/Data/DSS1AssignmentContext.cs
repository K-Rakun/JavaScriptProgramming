using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DSS1Assignment.Models;

namespace DSS1Assignment.Data
{
    public class DSS1AssignmentContext : DbContext
    {
        public DSS1AssignmentContext (DbContextOptions<DSS1AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<DSS1Assignment.Models.Movie>? Movie { get; set; }

        public DbSet<DSS1Assignment.Models.Image>? Image { get; set; }
    }
}
