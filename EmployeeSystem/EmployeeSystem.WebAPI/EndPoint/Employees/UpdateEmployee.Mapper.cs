using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Command;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class UpdateEmployeeMapper : Profile
    {
        public UpdateEmployeeMapper()
        {
            CreateMap<UpdateEmployeeEndPointRequest, UpdateEmployeeHandlerInput>()
                .ConstructUsing(src => new UpdateEmployeeHandlerInput(src.CorrelationId()));
            CreateMap<UpdateEmployeeHandlerOutput, UpdateEmployeeEndPointResponse>()
               .ConstructUsing(src => new UpdateEmployeeEndPointResponse(src.CorrelationId()));
        }

    }
}
