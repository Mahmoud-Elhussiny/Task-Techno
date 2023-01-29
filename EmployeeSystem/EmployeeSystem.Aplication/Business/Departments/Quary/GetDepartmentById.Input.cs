using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Departments.Quary
{
    public class GetDepartmentByIdHandlerInput : BaseRequest, IRequest<GetDepartmentByIdHandlerOutput>
    {
        public GetDepartmentByIdHandlerInput() { }
        public GetDepartmentByIdHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
