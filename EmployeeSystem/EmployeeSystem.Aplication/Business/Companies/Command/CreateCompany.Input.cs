using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class CreateCompanyHandlerInput : BaseRequest, IRequest<CreateCompanyHandlerOutput>
    {
        public CreateCompanyHandlerInput() { }
        public CreateCompanyHandlerInput(Guid correlationId) : base(correlationId) { }

        public string Name { get; set; }

    }
}
