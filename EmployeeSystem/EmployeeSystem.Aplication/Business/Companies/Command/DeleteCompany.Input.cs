using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class DeleteCompanyHandlerInput : BaseRequest, IRequest<DeleteCompanyHandlerOutput>
    {
        public DeleteCompanyHandlerInput() { }
        public DeleteCompanyHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
