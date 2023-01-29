using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class UpdateDepartmentMapper : Profile
    {
        public UpdateDepartmentMapper()
        {
            CreateMap<UpdateDepartmentEndPointRequest, UpdateDepartmentHandlerInput>()
                .ConstructUsing(src => new UpdateDepartmentHandlerInput(src.CorrelationId()));
            CreateMap<UpdateDepartmentHandlerOutput, UpdateDepartmentEndPointResponse>()
               .ConstructUsing(src => new UpdateDepartmentEndPointResponse(src.CorrelationId()));
        }

    }
}
