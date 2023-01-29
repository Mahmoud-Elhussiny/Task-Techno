using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Quary;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetDepartmentByIdMapper : Profile
    {
        public GetDepartmentByIdMapper()
        {
            CreateMap<GetDepartmentByIdEndPointRequest, GetDepartmentByIdHandlerInput>()
                .ConstructUsing(src => new GetDepartmentByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetDepartmentByIdHandlerOutput, GetDepartmentByIdEndPointResponse>()
               .ConstructUsing(src => new GetDepartmentByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
