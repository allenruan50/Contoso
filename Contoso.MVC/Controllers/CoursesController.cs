using Contoso.Models;
using Contoso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Contoso.MVC.Controllers
{
    public class CoursesController : Controller
    {
        private CoursesServices _coursesservices;
        public CoursesController()
        {
            _coursesservices = new CoursesServices();
        }
        // GET: Courses
        public ActionResult Index()
        {
            var courses = _coursesservices.GetCourses();
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            try
            {
                course.DepartmentId = 1;
                course.CreatedDate = DateTime.Now;
                course.UpdatedDate = DateTime.Now;
                _coursesservices.CreaeteCourses(course);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}