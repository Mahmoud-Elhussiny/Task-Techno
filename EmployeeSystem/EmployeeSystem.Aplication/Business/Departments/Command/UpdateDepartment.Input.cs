using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class UpdateDepartmentHandlerInput : BaseRequest, IRequest<UpdateDepartmentHandlerOutput>
    {
        public UpdateDepartmentHandlerInput() { }
        public UpdateDepartmentHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string? Name { get; set; }

        public int? CompanyId { get; set; }

    }
}
