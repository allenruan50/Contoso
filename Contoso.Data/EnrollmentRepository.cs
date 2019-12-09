using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class EnrollmentRepository
    {
        ContosoDbContext Db = new ContosoDbContext();
        public Enrollment GetEnrollmentById(int id)
        {
            return Db.Enrollments.FirstOrDefault(r => r.Id == id);
        }
    }
}
