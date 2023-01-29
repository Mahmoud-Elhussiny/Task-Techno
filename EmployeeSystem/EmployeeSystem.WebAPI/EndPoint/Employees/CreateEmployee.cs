using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class CreateEmployeeEndPoint : EndpointBaseAsync
    .WithRequest<CreateEmployeeEndPointRequest>
    .WithActionResult<CreateEmployeeEndPointResponse>
    {
        private readonly ILogger<CreateEmployeeEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateEmployeeEndPoint(ILogger<CreateEmployeeEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        [Authorize(Roles = "admin")]
        [HttpPost(CreateEmployeeEndPointRequest.Route)]
        [Produces("application/json")]
   
        public override async Task<ActionResult<CreateEmployeeEndPointResponse>> HandleAsync([FromBody] CreateEmployeeEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateEmployee handling");
            var Appinput = _mapper.Map<CreateEmployeeHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateEmployeeEndPointResponse>(result));
        }
    }
}
