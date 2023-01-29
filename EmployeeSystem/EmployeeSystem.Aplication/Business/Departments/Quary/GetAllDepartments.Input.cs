using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Departments.Quary
{
    public class GetAllDepartmentsHandlerInput : BaseRequest, IRequest<GetAllDepartmentsHandlerOutput>
    {
        public GetAllDepartmentsHandlerInput() { }
        public GetAllDepartmentsHandlerInput(Guid correlationId) : base(correlationId) { }


    }
}
