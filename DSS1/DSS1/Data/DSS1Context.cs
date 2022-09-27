using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DSS1.Models;

namespace DSS1.Data
{
    public class DSS1Context : DbContext
    {
        public DSS1Context (DbContextOptions<DSS1Context> options)
            : base(options)
        {
        }

        public DbSet<DSS1.Models.Movie>? Movie { get; set; }

        public DbSet<DSS1.Models.Image>? Image { get; set; }
    }
}
