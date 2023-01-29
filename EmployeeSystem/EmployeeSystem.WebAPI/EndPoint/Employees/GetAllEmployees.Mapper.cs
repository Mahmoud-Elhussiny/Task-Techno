using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Quary;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetAllEmployeesMapper : Profile
    {
        public GetAllEmployeesMapper()
        {
            CreateMap<GetAllEmployeesEndPointRequest, GetAllEmployeesHandlerInput>()
                .ConstructUsing(src => new GetAllEmployeesHandlerInput(src.CorrelationId()));
            CreateMap<GetAllEmployeesHandlerOutput, GetAllEmployeesEndPointResponse>()
               .ConstructUsing(src => new GetAllEmployeesEndPointResponse(src.CorrelationId()));
        }

    }
}
