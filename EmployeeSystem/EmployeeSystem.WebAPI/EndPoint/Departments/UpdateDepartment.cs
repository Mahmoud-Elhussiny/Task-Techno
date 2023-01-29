using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class UpdateDepartmentEndPoint : EndpointBaseAsync
    .WithRequest<UpdateDepartmentEndPointRequest>
    .WithActionResult<UpdateDepartmentEndPointResponse>
    {
        private readonly ILogger<UpdateDepartmentEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UpdateDepartmentEndPoint(ILogger<UpdateDepartmentEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpPut(UpdateDepartmentEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<UpdateDepartmentEndPointResponse>> HandleAsync([FromBody] UpdateDepartmentEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting UpdateDepartment handling");
            var Appinput = _mapper.Map<UpdateDepartmentHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<UpdateDepartmentEndPointResponse>(result));
        }
    }
}
