using EmployeeSystem.Aplication.Interfaces;
using EmployeeSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class CreateCompanyHandler : IRequestHandler<CreateCompanyHandlerInput, CreateCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateCompanyHandler> _logger;
        public CreateCompanyHandler(ILogger<CreateCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateCompanyHandlerOutput> Handle(CreateCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateCompany business logic");
            CreateCompanyHandlerOutput output = new CreateCompanyHandlerOutput(request.CorrelationId());

            var newcompany = new Company();
             
            newcompany.Name = request.Name; 


            await _databaseService.Companies.AddAsync(newcompany);

            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
                throw new Exception( "Can't Saved Data");

            output.Messages = "Data saved Susseccfully";

            return output;
        }
    }
}
