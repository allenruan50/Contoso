using Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class OfficeAssignmentsRepository
    {
        ContosoDbContext Db = new ContosoDbContext();
        public OfficeAssignments GetOfficeAssignmentsById(int id)
        {
            return Db.OfficeAssignments.FirstOrDefault(o => o.InstructorId == id);
        }
    }
}
