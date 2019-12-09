using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class ContosoDbContext : DbContext
    {
        public ContosoDbContext() : base("Name = ContosoDbContext")
        { }
        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Models.Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignments> OfficeAssignments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
