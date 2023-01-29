using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Companies.Quary
{
    public class GetCompanyByIdHandlerInput : BaseRequest, IRequest<GetCompanyByIdHandlerOutput>
    {
        public GetCompanyByIdHandlerInput() { }
        public GetCompanyByIdHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
