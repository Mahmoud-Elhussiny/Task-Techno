using EmployeeSystem.Aplication.Interfaces;
using EmployeeSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Persistence.Context
{
    public partial class DatabaseService:IDatabaseService
    {
        public int DBSaveChanges()
        {
            return SaveChanges();
        }

        public async Task<int> DBSaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);
        }
    }
}
