using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Quary;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetAllDepartmentsEndPoint : EndpointBaseAsync
    .WithRequest<GetAllDepartmentsEndPointRequest>
    .WithActionResult<GetAllDepartmentsEndPointResponse>
    {
        private readonly ILogger<GetAllDepartmentsEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public GetAllDepartmentsEndPoint(ILogger<GetAllDepartmentsEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [Authorize]
        [HttpGet(GetAllDepartmentsEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<GetAllDepartmentsEndPointResponse>> HandleAsync([FromQuery] GetAllDepartmentsEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting GetAllDepartments handling");
            var Appinput = _mapper.Map<GetAllDepartmentsHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<GetAllDepartmentsEndPointResponse>(result));
        }
    }
}
