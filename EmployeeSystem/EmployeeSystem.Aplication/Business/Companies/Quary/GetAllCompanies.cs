using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Companies.Quary
{
    public class GetAllCompaniesHandler : IRequestHandler<GetAllCompaniesHandlerInput, GetAllCompaniesHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllCompaniesHandler> _logger;
        public GetAllCompaniesHandler(ILogger<GetAllCompaniesHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllCompaniesHandlerOutput> Handle(GetAllCompaniesHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllCompanies business logic");
            GetAllCompaniesHandlerOutput output = new GetAllCompaniesHandlerOutput(request.CorrelationId());

            var allcomp = await _databaseService.Companies.Select(o => new allcompany
            {
                Id = o.Id,
                Name = o.Name

            }).ToListAsync(cancellationToken);

            output.allcompanies = allcomp;
            return output;
        }
    }
}
