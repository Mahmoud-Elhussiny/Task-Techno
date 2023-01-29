using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeHandlerInput, DeleteEmployeeHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeleteEmployeeHandler> _logger;
        public DeleteEmployeeHandler(ILogger<DeleteEmployeeHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeleteEmployeeHandlerOutput> Handle(DeleteEmployeeHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeleteEmployee business logic");
            DeleteEmployeeHandlerOutput output = new DeleteEmployeeHandlerOutput(request.CorrelationId());

            var employeeDeleted = await _databaseService.Employees
                .FirstOrDefaultAsync(o => o.Id == request.Id, cancellationToken);

            if (employeeDeleted == null)
                throw new Exception("this Employee is not found");

            _databaseService.Employees.Remove(employeeDeleted);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new Exception("Can't Delete Data");

            output.Messages = "Data Deleted Susseccfully";


            return output;
        }
    }
}
