using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeHandlerInput, UpdateEmployeeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdateEmployeeHandler> _logger;
        public UpdateEmployeeHandler(ILogger<UpdateEmployeeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdateEmployeeHandlerOutput> Handle(UpdateEmployeeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdateEmployee business logic");
            UpdateEmployeeHandlerOutput output = new UpdateEmployeeHandlerOutput(request.CorrelationId());

            var employeeUpdated = await _databaseService.Employees.Include(o=>o.Departments)
                .FirstOrDefaultAsync(o => o.Id == request.Id,cancellationToken);

            if (employeeUpdated == null)
                throw new Exception("This Employee is Not Found");

            if (!String.IsNullOrEmpty(request.Name))
                employeeUpdated.Name = request.Name;

            if (!String.IsNullOrEmpty(request.UserName))
                employeeUpdated.UserName = request.UserName;
            if (!String.IsNullOrEmpty(request.password))
                employeeUpdated.password = request.password;

            if (!String.IsNullOrEmpty(request.address))
                employeeUpdated.address = request.address;

            if (request.isAdmin.HasValue) 
                employeeUpdated.isAdmin = request.isAdmin.Value;

            if (request.Departments_Id!.Count() > 0)
            {
                employeeUpdated.Departments.Clear();
                request.Departments_Id!.ForEach(async o =>
                {
                    var departs = await _databaseService.Departments
                    .FirstOrDefaultAsync(s => s.Id == o);

                    if (departs == null)
                        throw new Exception($"this Department {o} is not found");

                    employeeUpdated.Departments.Add(departs);

                });
            }
             _databaseService.Employees.Update(employeeUpdated);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new Exception("Can't Update Data");

            output.Messages = "Data Updated Susseccfully";



            return output;
        }
    }
}
