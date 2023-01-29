using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Quary;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetAllDepartmentsMapper : Profile
    {
        public GetAllDepartmentsMapper()
        {
            CreateMap<GetAllDepartmentsEndPointRequest, GetAllDepartmentsHandlerInput>()
                .ConstructUsing(src => new GetAllDepartmentsHandlerInput(src.CorrelationId()));
            CreateMap<GetAllDepartmentsHandlerOutput, GetAllDepartmentsEndPointResponse>()
               .ConstructUsing(src => new GetAllDepartmentsEndPointResponse(src.CorrelationId()));
        }

    }
}
