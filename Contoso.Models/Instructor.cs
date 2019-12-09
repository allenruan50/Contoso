using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    [Table("Instructors")]
    public class Instructor : Person
    {
        public new int Id { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
