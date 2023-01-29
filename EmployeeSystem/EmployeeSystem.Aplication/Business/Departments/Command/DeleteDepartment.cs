using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentHandlerInput, DeleteDepartmentHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeleteDepartmentHandler> _logger;
        public DeleteDepartmentHandler(ILogger<DeleteDepartmentHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeleteDepartmentHandlerOutput> Handle(DeleteDepartmentHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeleteDepartment business logic");
            DeleteDepartmentHandlerOutput output = new DeleteDepartmentHandlerOutput(request.CorrelationId());

            var departmentDeleted = await _databaseService.Departments.FirstOrDefaultAsync(o => o.Id == request.Id);

            if (departmentDeleted == null)
            {
                throw new Exception("This Department IS Not found");
            }

            _databaseService.Departments.Remove(departmentDeleted);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new Exception("Error In Delet Data");
            }

            output.Messages = "Data Delted Successfully";


            return output;
        }
    }
}
