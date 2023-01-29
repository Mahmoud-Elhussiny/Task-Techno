using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesHandlerInput, GetAllEmployeesHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllEmployeesHandler> _logger;
        public GetAllEmployeesHandler(ILogger<GetAllEmployeesHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllEmployeesHandlerOutput> Handle(GetAllEmployeesHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllEmployees business logic");
            GetAllEmployeesHandlerOutput output = new GetAllEmployeesHandlerOutput(request.CorrelationId());

            
            var allemployees = await _databaseService.Employees
                .Include(o => o.Departments)
                .ToListAsync(cancellationToken);


            var outputemployyee = new List<AllEmployees>();
            foreach (var emp in allemployees)
            {

                var singleEmployee = new AllEmployees();
                singleEmployee.Id = emp.Id;
                singleEmployee.Name = emp.Name;
                singleEmployee.address = emp.address;
                singleEmployee.UserName = emp.UserName;
                singleEmployee.password = emp.password;
                singleEmployee.isAdmin = emp.isAdmin;
                singleEmployee.DepartmentsName = new List<string>();

                emp.Departments
                    .ForEach(d => singleEmployee.DepartmentsName.Add(d.Name));

                outputemployyee.Add(singleEmployee);
            }


            output.allEmployees = outputemployyee;

            return output;

        
        }
    }
}
