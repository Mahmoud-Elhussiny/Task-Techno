using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Domain
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        [Required]
        public string UserName { get; set; } = "";
        [Required]
        public string password { get; set; } = "";

        public string? address { get; set; }

        public bool isAdmin { get; set; }

        public List<Department> Departments { get; set; } = null!;

    }
}
