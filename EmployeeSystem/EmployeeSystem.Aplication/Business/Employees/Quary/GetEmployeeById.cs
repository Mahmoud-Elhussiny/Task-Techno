using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdHandlerInput, GetEmployeeByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetEmployeeByIdHandler> _logger;
        public GetEmployeeByIdHandler(ILogger<GetEmployeeByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetEmployeeByIdHandlerOutput> Handle(GetEmployeeByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GitEmployeeById business logic");
            GetEmployeeByIdHandlerOutput output = new GetEmployeeByIdHandlerOutput(request.CorrelationId());

            var employeeSelected = await _databaseService.Employees
               .FirstOrDefaultAsync(o => o.Id == request.Id, cancellationToken);

            if (employeeSelected == null)
                throw new Exception("This Employee is Not Found");

            output.Id = employeeSelected.Id;
            output.Name = employeeSelected.Name;
            output.UserName = employeeSelected.UserName;
            output.password = employeeSelected.password;
            output.address = employeeSelected.address;
            output.isAdmin = employeeSelected.isAdmin;

            return output;
        }
    }
}
