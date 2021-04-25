using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class Employee
    {
        [Required]
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public float salary { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}