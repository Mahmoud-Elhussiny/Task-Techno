using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class DeleteEmployeeEndPoint : EndpointBaseAsync
    .WithRequest<DeleteEmployeeEndPointRequest>
    .WithActionResult<DeleteEmployeeEndPointResponse>
    {
        private readonly ILogger<DeleteEmployeeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteEmployeeEndPoint(ILogger<DeleteEmployeeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpDelete(DeleteEmployeeEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<DeleteEmployeeEndPointResponse>> HandleAsync([FromQuery] DeleteEmployeeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteEmployee handling");
            var Appinput = _mapper.Map<DeleteEmployeeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteEmployeeEndPointResponse>(result));
        }
    }
}
