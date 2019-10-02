using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string Fname { get; set; }
        [DisplayName("Employee Code")]
        public string ECode { get; set; }

        public string  Position { get; set; }
        [DisplayName("Location")]
        public string OL { get; set; }
    }
}
