using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Companies.Quary
{
    public class GetAllCompaniesHandlerInput : BaseRequest, IRequest<GetAllCompaniesHandlerOutput>
    {
        public GetAllCompaniesHandlerInput() { }
        public GetAllCompaniesHandlerInput(Guid correlationId) : base(correlationId) { }
        
    }

}
