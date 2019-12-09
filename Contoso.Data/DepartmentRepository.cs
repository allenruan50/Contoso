using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {

        //ContosoDbContext Db = new ContosoDbContext();
        //public Department GetDepartmentById(int id)
        //{
        //    return Db.Departments.FirstOrDefault(d => d.ID == id);
        //}
        //public IEnumerable<Department> GetAllDepartment()
        //{
        //    return Db.Departments.ToList();
        //}
        //public Department GetDepartmentByName(string name)
        //{
        //    return Db.Departments.FirstOrDefault(d => d.Name == name);
        //}
        //public Department GetHighestBudgetDepartment()
        //{
        //    return Db.Departments.OrderByDescending(d => d.Budget).FirstOrDefault(); ;
        //}
        //public void Create(Department department)
        //{
        //    using (var db = new ContosoDbContext())
        //    {
        //        db.Departments.Add(department);
        //        db.SaveChanges();
        //    }
        //}
        //public void Update(Department department)
        //{
        //    using (var db = new ContosoDbContext())
        //    {
        //        var departmentById = db.Departments.Find(department.ID);
        //        //departmentById = department;
        //        departmentById.Name = department.Name;
        //        departmentById.Budget = department.Budget;
        //        departmentById.StartDate = department.StartDate;
        //        db.SaveChanges();
        //    }
        //}
        public DepartmentRepository(ContosoDbContext context) : base(context)//access base class
        {
            
        }

        public Department GetDepartmentByName(string name)
        {
            var department = _dbContext.Departments.FirstOrDefault(d => d.Name == name); 
            return department;
        }
    }
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department GetDepartmentByName(string name);
    }
}
