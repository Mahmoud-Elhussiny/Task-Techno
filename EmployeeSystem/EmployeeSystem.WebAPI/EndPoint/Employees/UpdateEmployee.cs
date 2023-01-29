using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class UpdateEmployeeEndPoint : EndpointBaseAsync
    .WithRequest<UpdateEmployeeEndPointRequest>
    .WithActionResult<UpdateEmployeeEndPointResponse>
    {
        private readonly ILogger<UpdateEmployeeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UpdateEmployeeEndPoint(ILogger<UpdateEmployeeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPut(UpdateEmployeeEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<UpdateEmployeeEndPointResponse>> HandleAsync([FromBody] UpdateEmployeeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting UpdateEmployee handling");
            var Appinput = _mapper.Map<UpdateEmployeeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<UpdateEmployeeEndPointResponse>(result));
        }
    }
}
