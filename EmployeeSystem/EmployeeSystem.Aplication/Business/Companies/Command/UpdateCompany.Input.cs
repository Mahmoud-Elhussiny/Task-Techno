using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class UpdateCompanyHandlerInput : BaseRequest, IRequest<UpdateCompanyHandlerOutput>
    {
        public UpdateCompanyHandlerInput() { }
        public UpdateCompanyHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
