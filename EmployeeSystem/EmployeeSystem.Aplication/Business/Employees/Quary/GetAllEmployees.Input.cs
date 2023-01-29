using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetAllEmployeesHandlerInput : BaseRequest, IRequest<GetAllEmployeesHandlerOutput>
    {
        public GetAllEmployeesHandlerInput() { }
        public GetAllEmployeesHandlerInput(Guid correlationId) : base(correlationId) { }

    }
}
