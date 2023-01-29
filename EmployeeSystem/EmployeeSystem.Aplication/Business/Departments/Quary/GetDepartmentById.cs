using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Departments.Quary
{
    public class GetDepartmentByIdHandler : IRequestHandler<GetDepartmentByIdHandlerInput, GetDepartmentByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetDepartmentByIdHandler> _logger;
        public GetDepartmentByIdHandler(ILogger<GetDepartmentByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetDepartmentByIdHandlerOutput> Handle(GetDepartmentByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetDepartmentById business logic");
            GetDepartmentByIdHandlerOutput output = new GetDepartmentByIdHandlerOutput(request.CorrelationId());

            var departmentSelected = await _databaseService.Departments.FirstOrDefaultAsync(o => o.Id == request.Id);

            if (departmentSelected == null)
            {
                throw new Exception("This Company IS Not found");
            }

            output.Id = departmentSelected.Id;
            output.Name = departmentSelected.Name;
            output.CompanyId = departmentSelected.CompanyId;
            
            return output;
        }
    }
}
