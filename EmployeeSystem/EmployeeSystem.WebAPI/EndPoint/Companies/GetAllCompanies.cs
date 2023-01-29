using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Quary;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetAllCompaniesEndPoint : EndpointBaseAsync
    .WithRequest<GetAllCompaniesEndPointRequest>
    .WithActionResult<GetAllCompaniesEndPointResponse>
    {
        private readonly ILogger<GetAllCompaniesEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllCompaniesEndPoint(ILogger<GetAllCompaniesEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetAllCompaniesEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<GetAllCompaniesEndPointResponse>> HandleAsync([FromQuery] GetAllCompaniesEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllCompanies handling");
            var Appinput = _mapper.Map<GetAllCompaniesHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllCompaniesEndPointResponse>(result));
        }
    }
}
