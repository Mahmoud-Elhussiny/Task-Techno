using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class UpdateCompanyHandler : IRequestHandler<UpdateCompanyHandlerInput, UpdateCompanyHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<UpdateCompanyHandler> _logger;
        public UpdateCompanyHandler(ILogger<UpdateCompanyHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<UpdateCompanyHandlerOutput> Handle(UpdateCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling UpdateCompany business logic");
            UpdateCompanyHandlerOutput output = new UpdateCompanyHandlerOutput(request.CorrelationId());

            var companyUpdated = await _databaseService.Companies.FirstOrDefaultAsync(o => o.Id == request.Id);

            if (companyUpdated == null)
            {
                throw new Exception("This Company IS Not found");
            }
            if (!String.IsNullOrEmpty(request.Name))
            {
                companyUpdated.Name = request.Name;
            }
            _databaseService.Companies.Update(companyUpdated);
            if(await _databaseService.DBSaveChangesAsync(cancellationToken) == 0)
            {
                throw new Exception("Error In Updating Data");
            }

            output.Messages = "Data Updated Successfully";
        

            return output;
        }
    }
}
