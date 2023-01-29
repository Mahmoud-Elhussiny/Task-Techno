using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Domain
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;

        public List<Employee>? Employees { get; set; }

    }
}
