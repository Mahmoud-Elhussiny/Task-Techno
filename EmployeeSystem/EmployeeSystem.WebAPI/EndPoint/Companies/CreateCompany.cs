using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class CreateCompanyEndPoint : EndpointBaseAsync
    .WithRequest<CreateCompanyEndPointRequest>
    .WithActionResult<CreateCompanyEndPointResponse>
    {
        private readonly ILogger<CreateCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateCompanyEndPoint(ILogger<CreateCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPost(CreateCompanyEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<CreateCompanyEndPointResponse>> HandleAsync([FromBody] CreateCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateCompany handling");
            var Appinput = _mapper.Map<CreateCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateCompanyEndPointResponse>(result));
        }
    }
}
