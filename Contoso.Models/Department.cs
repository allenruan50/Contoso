using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        public int InstructorId { get; set; }
        public string RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public ICollection<Course> Courses { get; set; }
        public Instructor Instructor { get; set; }
    }
}
