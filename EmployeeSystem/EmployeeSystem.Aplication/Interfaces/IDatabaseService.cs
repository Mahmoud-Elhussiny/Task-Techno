using EmployeeSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Aplication.Interfaces
{
    public interface IDatabaseService
    {
        int DBSaveChanges();
        Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default);


        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
