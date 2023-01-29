using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class DeleteEmployeeHandlerInput : BaseRequest, IRequest<DeleteEmployeeHandlerOutput>
    {
        public DeleteEmployeeHandlerInput() { }
        public DeleteEmployeeHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }

    }
}
