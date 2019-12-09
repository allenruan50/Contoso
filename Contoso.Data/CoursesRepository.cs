using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class CoursesRepository
    {
        public Course GetCourseById(int id)
        {
            using (var _db = new ContosoDbContext())
            {
                return _db.Courses.FirstOrDefault(r => r.Id == id);
            }
        }
        public IEnumerable<Course> GetCourses()
        {
            using (var _db = new ContosoDbContext())
            {
                return _db.Courses.ToList();
            }
        }
        public void Create(Course course)
        {
            using (var _db = new ContosoDbContext())
            {
                _db.Courses.Add(course);
                _db.SaveChanges();
            }
        }
    }
}
