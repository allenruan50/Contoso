using Contoso.Data;
using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)//any class implement the interface can be passed
        {
            _departmentRepository = departmentRepository;
        }
        public void CreateDepartment(Department department)
        {

        }

        public IEnumerable<Department> GetAllDepartents()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return _departmentRepository.GetById(Id);
        }

        public Department GetDepartmentByName(string Name)
        {
            return _departmentRepository.GetDepartmentByName(Name);
        }

        public int GetTotalDepartmentCount()
        {
            throw new NotImplementedException();
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartents();
        int GetTotalDepartmentCount();
        Department GetDepartmentById(int Id);
        Department GetDepartmentByName(string Name);
        void CreateDepartment(Department department);

    }
    public class DepartmentService2 : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService2(IDepartmentRepository departmentRepository)//any class implement the interface can be passed
        {
            _departmentRepository = departmentRepository;
        }
        public void CreateDepartment(Department department)
        {

        }

        public IEnumerable<Department> GetAllDepartents()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return _departmentRepository.GetById(Id);
        }

        public Department GetDepartmentByName(string Name)
        {
            return _departmentRepository.GetDepartmentByName(Name);
        }

        public int GetTotalDepartmentCount()
        {
            throw new NotImplementedException();
        }
    }

}
