using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class CreateDepartmentHandlerInput : BaseRequest, IRequest<CreateDepartmentHandlerOutput>
    {
        public CreateDepartmentHandlerInput() { }
        public CreateDepartmentHandlerInput(Guid correlationId) : base(correlationId) { }
        
        public string Name { get; set; }

        public int CompanyId { get; set; }


    }
}
