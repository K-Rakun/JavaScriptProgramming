using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentDSS1.Models;

namespace AssignmentDSS1.Data
{
    public class AssignmentDSS1Context : DbContext
    {
        public AssignmentDSS1Context (DbContextOptions<AssignmentDSS1Context> options)
            : base(options)
        {
        }

        public DbSet<AssignmentDSS1.Models.Movie>? Movie { get; set; }
        public DbSet<AssignmentDSS1.Models.ReleaseDate>? ReleaseDate { get;}
    }
}
