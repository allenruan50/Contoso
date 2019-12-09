using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class StudentServices
    {
        StudentRepository repo = new StudentRepository();
        public Student GetById(int id)
        {
            return repo.GetStudentById(id);
        }
    }
}
