using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeedingData_MVC.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }  
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int Age { get; set; }

    }
}