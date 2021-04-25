using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class Brand
    {
        [Required]
        public int BrandId { get; set; }
        public string name { get; set; }

    }
}