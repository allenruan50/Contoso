using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class InstructorRepository
    {
        ContosoDbContext Db = new ContosoDbContext();
        public Instructor GetInstructorById(int id)
        {
            return Db.Instructors.FirstOrDefault(i => i.Id == id);
        }
    }
}
