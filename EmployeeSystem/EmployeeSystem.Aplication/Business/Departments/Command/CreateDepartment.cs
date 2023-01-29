using EmployeeSystem.Aplication.Interfaces;
using EmployeeSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentHandlerInput, CreateDepartmentHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateDepartmentHandler> _logger;
        public CreateDepartmentHandler(ILogger<CreateDepartmentHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateDepartmentHandlerOutput> Handle(CreateDepartmentHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateDepartment business logic");
            CreateDepartmentHandlerOutput output = new CreateDepartmentHandlerOutput(request.CorrelationId());

            var newDepartment = new Department();
            newDepartment.Name = request.Name;
            newDepartment.CompanyId = request.CompanyId;
            await _databaseService.Departments.AddAsync(newDepartment, cancellationToken);
            
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new Exception("Can't Saved Data");

            output.Messages = "Data saved Susseccfully";


            return output;
        }
    }
}
