using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Services;

namespace Contoso.MVC.Controllers
{
    public class InstructorController : Controller
    {
        private InstructorServices _instructorservice;
        public InstructorController()
        {
            _instructorservice = new InstructorServices();
        }
        // GET: Instructor
        public ActionResult Index()
        {
            var instructor = _instructorservice.GetById(1);
            return View();
        }
    }
}