using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class Department
    {
        [Required]
        public int Id { get; set; }
        public string name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}