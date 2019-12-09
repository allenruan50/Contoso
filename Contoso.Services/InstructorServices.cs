using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class InstructorServices
    {
        InstructorRepository repo = new InstructorRepository();
        public Instructor GetById(int id)
        {
            return repo.GetInstructorById(id);
        }

    }
}
