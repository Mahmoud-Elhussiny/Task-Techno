using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class CreateDepartmentMapper : Profile
    {
        public CreateDepartmentMapper()
        {
            CreateMap<CreateDepartmentEndPointRequest, CreateDepartmentHandlerInput>()
                .ConstructUsing(src => new CreateDepartmentHandlerInput(src.CorrelationId()));
            CreateMap<CreateDepartmentHandlerOutput, CreateDepartmentEndPointResponse>()
               .ConstructUsing(src => new CreateDepartmentEndPointResponse(src.CorrelationId()));
        }

    }
}
