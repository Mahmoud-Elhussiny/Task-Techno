using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Quary;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetAllEmployeesEndPoint : EndpointBaseAsync
    .WithRequest<GetAllEmployeesEndPointRequest>
    .WithActionResult<GetAllEmployeesEndPointResponse>
    {
        private readonly ILogger<GetAllEmployeesEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllEmployeesEndPoint(ILogger<GetAllEmployeesEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetAllEmployeesEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<GetAllEmployeesEndPointResponse>> HandleAsync([FromQuery] GetAllEmployeesEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllEmployees handling");
            var Appinput = _mapper.Map<GetAllEmployeesHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllEmployeesEndPointResponse>(result));
        }
    }
}
