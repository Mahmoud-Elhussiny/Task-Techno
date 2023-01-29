using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class DeleteDepartmentMapper : Profile
    {
        public DeleteDepartmentMapper()
        {
            CreateMap<DeleteDepartmentEndPointRequest, DeleteDepartmentHandlerInput>()
                .ConstructUsing(src => new DeleteDepartmentHandlerInput(src.CorrelationId()));
            CreateMap<DeleteDepartmentHandlerOutput, DeleteDepartmentEndPointResponse>()
               .ConstructUsing(src => new DeleteDepartmentEndPointResponse(src.CorrelationId()));
        }

    }
}
