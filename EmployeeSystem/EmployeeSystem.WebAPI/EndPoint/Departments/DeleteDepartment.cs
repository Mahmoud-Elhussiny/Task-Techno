using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class DeleteDepartmentEndPoint : EndpointBaseAsync
    .WithRequest<DeleteDepartmentEndPointRequest>
    .WithActionResult<DeleteDepartmentEndPointResponse>
    {
        private readonly ILogger<DeleteDepartmentEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteDepartmentEndPoint(ILogger<DeleteDepartmentEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpDelete(DeleteDepartmentEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<DeleteDepartmentEndPointResponse>> HandleAsync([FromQuery] DeleteDepartmentEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteDepartment handling");
            var Appinput = _mapper.Map<DeleteDepartmentHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteDepartmentEndPointResponse>(result));
        }
    }
}
