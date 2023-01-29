using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class UpdateDepartmentHandler : IRequestHandler<UpdateDepartmentHandlerInput, UpdateDepartmentHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdateDepartmentHandler> _logger;
        public UpdateDepartmentHandler(ILogger<UpdateDepartmentHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdateDepartmentHandlerOutput> Handle(UpdateDepartmentHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdateDepartment business logic");
            UpdateDepartmentHandlerOutput output = new UpdateDepartmentHandlerOutput(request.CorrelationId());

            var departmentUpdated = await _databaseService.Departments.FirstOrDefaultAsync(o => o.Id == request.Id);

            if (departmentUpdated == null)
            {
                throw new Exception("This Department IS Not found");
            }
            if (!String.IsNullOrEmpty(request.Name))
            {
                departmentUpdated.Name = request.Name;
            }

            if (request.CompanyId.HasValue)
            {
                departmentUpdated.CompanyId = request.CompanyId.Value;
            }


            _databaseService.Departments.Update(departmentUpdated);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new Exception("Error In Updating Data");
            }

            output.Messages = "Data Updated Successfully";


            return output;
        }
    }
}
