using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<University.Models.Student> Student { get; set; } = default!;
        public DbSet<University.Models.Course> Course { get; set; } = default!;
        public DbSet<University.Models.Enrollment> Enrollment { get; set; } = default!;
    }
}
