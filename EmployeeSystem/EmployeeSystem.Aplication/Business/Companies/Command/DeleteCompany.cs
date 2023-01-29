using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class DeleteCompanyHandler : IRequestHandler<DeleteCompanyHandlerInput, DeleteCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<DeleteCompanyHandler> _logger;
        public DeleteCompanyHandler(ILogger<DeleteCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<DeleteCompanyHandlerOutput> Handle(DeleteCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling DeleteCompany business logic");
            DeleteCompanyHandlerOutput output = new DeleteCompanyHandlerOutput(request.CorrelationId());
            
            var companyDeleted = await _databaseService.Companies.FirstOrDefaultAsync(o => o.Id == request.Id);

            if (companyDeleted == null)
            {
                throw new Exception("This Company IS Not found");
            }
           
            _databaseService.Companies.Remove(companyDeleted);
            if (await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new Exception("Error In Delet Data");
            }

            output.Messages = "Data Delted Successfully";
        
            return output;
        }
    }
}
