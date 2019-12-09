using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class OfficeAssignments
    {
        public int InstructorId { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int id { get; set; }
        public Instructor Instructor { get; set; }
    }
}
