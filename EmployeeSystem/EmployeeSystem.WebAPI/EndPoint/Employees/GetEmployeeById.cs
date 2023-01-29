using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Quary;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetEmployeeByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetEmployeeByIdEndPointRequest>
    .WithActionResult<GetEmployeeByIdEndPointResponse>
    {
        private readonly ILogger<GetEmployeeByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetEmployeeByIdEndPoint(ILogger<GetEmployeeByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetEmployeeByIdEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<GetEmployeeByIdEndPointResponse>> HandleAsync([FromQuery] GetEmployeeByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetEmployeeById handling");
            var Appinput = _mapper.Map<GetEmployeeByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetEmployeeByIdEndPointResponse>(result));
        }
    }
}
