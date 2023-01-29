using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class DeleteDepartmentHandlerInput : BaseRequest, IRequest<DeleteDepartmentHandlerOutput>
    {
        public DeleteDepartmentHandlerInput() { }
        public DeleteDepartmentHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
