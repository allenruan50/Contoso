using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class OfficeAssignmentsServices
    {
        OfficeAssignmentsRepository repo = new OfficeAssignmentsRepository();
        public OfficeAssignments GetById(int id)
        {
            return repo.GetOfficeAssignmentsById(id);
        }
    }
}
