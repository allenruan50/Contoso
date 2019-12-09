using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class StudentRepository
    {
        ContosoDbContext Db = new ContosoDbContext();
        public Student GetStudentById(int id)
        {
            return Db.Students.FirstOrDefault(r => r.Id == id);
        }
    }
}
