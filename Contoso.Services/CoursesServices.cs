using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class CoursesServices
    {
        CoursesRepository repo = new CoursesRepository();
        public Course GetById(int id)
        {
            return repo.GetCourseById(id);
        }
        public IEnumerable<Course> GetCourses()
        {
            return repo.GetCourses();
        }
        public void CreaeteCourses(Course course)
        {
            repo.Create(course);
        }
    }
}
