using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
            : base("ProjectDbContext")
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}