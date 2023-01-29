using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Quary;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetDepartmentByIdEndPoint : EndpointBaseAsync
    .WithRequest<GetDepartmentByIdEndPointRequest>
    .WithActionResult<GetDepartmentByIdEndPointResponse>
    {
        private readonly ILogger<GetDepartmentByIdEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetDepartmentByIdEndPoint(ILogger<GetDepartmentByIdEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [HttpGet(GetDepartmentByIdEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<GetDepartmentByIdEndPointResponse>> HandleAsync([FromQuery] GetDepartmentByIdEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetDepartmentById handling");
            var Appinput = _mapper.Map<GetDepartmentByIdHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetDepartmentByIdEndPointResponse>(result));
        }
    }
}
