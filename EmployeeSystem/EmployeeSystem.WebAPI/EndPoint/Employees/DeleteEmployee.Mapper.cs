using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Command;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class DeleteEmployeeMapper : Profile
    {
        public DeleteEmployeeMapper()
        {
            CreateMap<DeleteEmployeeEndPointRequest, DeleteEmployeeHandlerInput>()
                .ConstructUsing(src => new DeleteEmployeeHandlerInput(src.CorrelationId()));
            CreateMap<DeleteEmployeeHandlerOutput, DeleteEmployeeEndPointResponse>()
               .ConstructUsing(src => new DeleteEmployeeEndPointResponse(src.CorrelationId()));
        }

    }
}
