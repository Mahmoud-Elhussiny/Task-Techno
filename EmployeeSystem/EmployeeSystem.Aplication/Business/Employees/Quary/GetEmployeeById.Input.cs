using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetEmployeeByIdHandlerInput : BaseRequest, IRequest<GetEmployeeByIdHandlerOutput>
    {
        public GetEmployeeByIdHandlerInput() { }
        public GetEmployeeByIdHandlerInput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
    }
}
