using EmployeeSystem.Aplication.Interfaces;
using EmployeeSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeHandlerInput, CreateEmployeeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateEmployeeHandler> _logger;
        public CreateEmployeeHandler(ILogger<CreateEmployeeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateEmployeeHandlerOutput> Handle(CreateEmployeeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateEmployee business logic");
            CreateEmployeeHandlerOutput output = new CreateEmployeeHandlerOutput(request.CorrelationId());

            var newEmployee = new Employee();
            newEmployee.Departments = new List<Department>();
            newEmployee.Name = request.Name;
            newEmployee.UserName = request.UserName;
            newEmployee.password = request.password;
            newEmployee.address = request.address;
            
            
            foreach(var dep in request.Departments_Id)
            {
                var departs = await _databaseService.Departments
               .FirstOrDefaultAsync(s => s.Id == dep);

                if (departs == null)
                    throw new Exception("this Department is not found");

                newEmployee.Departments.Add(departs);
            }
            
         

            await _databaseService.Employees
                .AddAsync(newEmployee, cancellationToken);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new Exception("Can't Saved Data");

            output.Messages = "Data saved Susseccfully";

            
            return output;
        }
    }
}
