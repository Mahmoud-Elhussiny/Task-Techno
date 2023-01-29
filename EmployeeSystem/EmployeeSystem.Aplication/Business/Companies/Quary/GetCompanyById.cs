using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Companies.Quary
{
    public class GetCompanyByIdHandler : IRequestHandler<GetCompanyByIdHandlerInput, GetCompanyByIdHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetCompanyByIdHandler> _logger;
        public GetCompanyByIdHandler(ILogger<GetCompanyByIdHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetCompanyByIdHandlerOutput> Handle(GetCompanyByIdHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetCompanyById business logic");
            GetCompanyByIdHandlerOutput output = new GetCompanyByIdHandlerOutput(request.CorrelationId());

            var companySelected = await _databaseService.Companies.FirstOrDefaultAsync(o => o.Id == request.Id);

            if (companySelected == null)
            {
                throw new Exception("This Company IS Not found");
            }

            output.Id = companySelected.Id;
            output.Name = companySelected.Name;
         
            return output;
        }
    }
}
