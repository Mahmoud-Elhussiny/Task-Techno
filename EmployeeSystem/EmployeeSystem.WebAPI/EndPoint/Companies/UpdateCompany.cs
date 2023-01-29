using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class UpdateCompanyEndPoint : EndpointBaseAsync
    .WithRequest<UpdateCompanyEndPointRequest>
    .WithActionResult<UpdateCompanyEndPointResponse>
    {
        private readonly ILogger<UpdateCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UpdateCompanyEndPoint(ILogger<UpdateCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPut(UpdateCompanyEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<UpdateCompanyEndPointResponse>> HandleAsync([FromBody] UpdateCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting UpdateCompany handling");
            var Appinput = _mapper.Map<UpdateCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<UpdateCompanyEndPointResponse>(result));
        }
    }
}
