using Contoso.Models;
using Contoso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Contoso.API.Controllers
{
    [RoutePrefix("api/departments")]//attribute routing
    public class DepartmentController : ApiController //inherit from ApiController and MVCController inherit from Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        
        [HttpGet]
        [Route("")]
        public IEnumerable<Department> GetDepartments()
        {
            var departments = _departmentService.GetAllDepartents();
            return departments;
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetDepartmentById(int id) //return type changed from Department to IHttpActionResult
        {
            var department = _departmentService.GetDepartmentById(id);
            if (department == null)
            {
                var response = Request.CreateResponse(HttpStatusCode.NotFound, "No department found.");
                return ResponseMessage(response);
            }
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.OK, department));
        }
    }
}
