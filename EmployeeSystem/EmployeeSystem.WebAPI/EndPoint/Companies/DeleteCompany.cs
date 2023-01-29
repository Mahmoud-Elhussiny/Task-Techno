using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class DeleteCompanyEndPoint : EndpointBaseAsync
    .WithRequest<DeleteCompanyEndPointRequest>
    .WithActionResult<DeleteCompanyEndPointResponse>
    {
        private readonly ILogger<DeleteCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteCompanyEndPoint(ILogger<DeleteCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        
        [HttpDelete(DeleteCompanyEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<DeleteCompanyEndPointResponse>> HandleAsync([FromQuery] DeleteCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteCompany handling");
            var Appinput = _mapper.Map<DeleteCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteCompanyEndPointResponse>(result));
        }
    }
}
