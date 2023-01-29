using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Quary;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetCompanyByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetCompanyByIdEndPointRequest>
    .WithActionResult<GetCompanyByIdEndPointResponse>
    {
        private readonly ILogger<GetCompanyByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetCompanyByIdEndPoint(ILogger<GetCompanyByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetCompanyByIdEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<GetCompanyByIdEndPointResponse>> HandleAsync([FromQuery] GetCompanyByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetCompanyById handling");
            var Appinput = _mapper.Map<GetCompanyByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetCompanyByIdEndPointResponse>(result));
        }
    }
}
