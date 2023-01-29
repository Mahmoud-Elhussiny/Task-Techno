using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.UserManegment.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace EmployeeSystem.WebAPI.EndPoint.UserManegment
{
    public class loginEndPoint : EndpointBaseAsync
    .WithRequest<loginEndPointRequest>
    .WithActionResult<loginEndPointResponse>
    {
        private readonly ILogger<loginEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public loginEndPoint(ILogger<loginEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(loginEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<loginEndPointResponse>> HandleAsync([FromBody] loginEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting login handling");
            var Appinput = _mapper.Map<loginHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<loginEndPointResponse>(result));
        }
    }
}
