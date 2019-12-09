using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string RoleName { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public ICollection<Person> People { get; set; }
    }
}
