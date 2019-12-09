using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Services
{
    public class EnrollmentServices
    {
        EnrollmentRepository repo = new EnrollmentRepository();
        public Enrollment GetById(int id)
        {
            return repo.GetEnrollmentById(id);
        }
    }
}
