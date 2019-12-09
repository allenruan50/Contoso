using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; //MS Test
using Contoso.Data;
using Contoso.Services;
using Contoso.Models;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Moq;

namespace Contoso.MVC.Tests.Services
{
    [TestClass]
    public class DepartmentServiceTest
    {
        private IDepartmentService _departmentService;
        private Mock<IDepartmentRepository> _mockDepartmentRepository;
        private List<Department> _departments;

        [TestInitialize]//to create the fake data for all the moethod
        public void Initialize()
        {
            _mockDepartmentRepository = new Mock<IDepartmentRepository>();//automatically create data in the run time
            _departmentService = new DepartmentService(_mockDepartmentRepository.Object);
            _departments = new List<Department>
            {
                new Department
                {
                    ID = 1,
                    Name = "CS",
                    Budget = 300,
                    StartDate = DateTime.Now
                },
                new Department
                {
                    ID = 1,
                    Name = "CS",
                    Budget = 300,
                    StartDate = DateTime.Now
                },
                new Department
                {
                    ID = 3,
                    Name = "Math",
                    Budget = 300,
                    StartDate = DateTime.Now
                },
                new Department
                {
                ID = 1,
                Name = "CS",
                Budget = 300,
                StartDate = DateTime.Now
                },
            };//initialize the fake data
            _mockDepartmentRepository.Setup(d => d.GetAll()).Returns(_departments);//anyone calling getall method will get _departments as return value
            _mockDepartmentRepository.Setup(d => d.GetById(It.IsAny<int>())).Returns((int s) => _departments.First(x => x.ID == s));
        }
        [TestMethod]
        public void CheckDepartmentCountFromFakeData()
        {
            //_departmentService = new DepartmentService(new MockDepartmentRepository());
            var departments = _departmentService.GetAllDepartents();
            Assert.IsNotNull(departments);
            Assert.AreEqual(4, departments.Count());
        }

        [TestMethod]
        public void CheckDepartmentGetByIdFromFakeData()
        {
            var department = _departmentService.GetDepartmentById(3);
            Assert.AreEqual("Math", department.Name);
        }

    }
    //public class MockDepartmentRepository : IDepartmentRepository
    //{
    //    public void Add(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department Get(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Department> GetAll()
    //    {
    //        var department = new List<Department>
    //        {
    //            new Department
    //            {
    //                ID = 1,
    //                Name = "CS",
    //                Budget = 300,
    //                StartDate = DateTime.Now
    //            },
    //            new Department
    //            {
    //                ID = 1,
    //                Name = "CS",
    //                Budget = 300,
    //                StartDate = DateTime.Now
    //            },
    //            new Department
    //            {
    //                ID = 1,
    //                Name = "CS",
    //                Budget = 300,
    //                StartDate = DateTime.Now
    //            },
    //            new Department
    //            {
    //            ID = 1,
    //            Name = "CS",
    //            Budget = 300,
    //            StartDate = DateTime.Now
    //            },
    //        };
    //        return department;
    //    }

    //    public Department GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int GetCount(Expression<Func<Department, bool>> filter = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department GetDepartmentByName(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<Department> GetMany(Expression<Func<Department, bool>> where)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveChanges()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(Department entity)
    //    {
    //        throw new NotImplementedException();
    //    }



    //}

}
