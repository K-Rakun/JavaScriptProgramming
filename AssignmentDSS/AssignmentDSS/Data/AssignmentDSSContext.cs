using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentDSS.Models;

namespace AssignmentDSS.Data
{
    public class AssignmentDSSContext : DbContext
    {
        public AssignmentDSSContext (DbContextOptions<AssignmentDSSContext> options)
            : base(options)
        {
        }

        public DbSet<AssignmentDSS.Models.Movie>? Movie { get; set; }
    }
}
