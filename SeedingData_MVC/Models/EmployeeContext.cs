using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SeedingData_MVC.Models;
using System.Data.Entity;

namespace SeedingData_MVC.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name = EmployeeContext")
        {
            
        }
        public DbSet<Employee> EmployeeData { get; set; }

    }
}