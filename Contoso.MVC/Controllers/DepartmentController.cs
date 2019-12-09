using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Models;
using Contoso.Services;
using Contoso.MVC.Filters;
using NLog;

namespace Contoso.MVC.Controllers
{
    [ContosoExceptionFilter]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentservice;
        public DepartmentController(IDepartmentService departmentservice)
        {
            //_departmentservice = new DepartmentService();
            _departmentservice = departmentservice;

        }
        // GET: Department
        public ActionResult Index()
        {
            int i = 0; int x = 1;
            int y = x / i; //for exception handling test
            var departments = _departmentservice.GetAllDepartents();
            //ViewData["depts"] = departments;
            ViewBag.DepartmentCount = departments.Count();
            return View(departments);
        }

        [HttpGet]//if nothing here, will be get bydefault
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            //get the data from formcollection and call service layer
            //save to the database
            try
            {
                //var departmentName = form["departmentname"];
                //var budget = form["budget"];
                //var startdate = form["startdate"];



                //Department department = new Department();
                //department.Name = departmentname;
                //department.Budget = Convert.ToDecimal(budget);
                //department.StartDate = Convert.ToDateTime(startdate);
                department.InstructorId = 1;
                department.CreatedDate = DateTime.Now;
                department.UpdatedDate = DateTime.Now;

                _departmentservice.CreateDepartment(department);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var department = _departmentservice.GetDepartmentById(id);
            return View(department);
        }
        [HttpPost]
        public ActionResult Edit(Department department)
        {
           // _departmentservice.UpdateDepartment(department);
            return RedirectToAction("Index");
        }
    }
}