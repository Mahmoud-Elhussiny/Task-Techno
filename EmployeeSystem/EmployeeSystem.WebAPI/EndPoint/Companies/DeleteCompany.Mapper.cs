using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class DeleteCompanyMapper : Profile
    {
        public DeleteCompanyMapper()
        {
            CreateMap<DeleteCompanyEndPointRequest, DeleteCompanyHandlerInput>()
                .ConstructUsing(src => new DeleteCompanyHandlerInput(src.CorrelationId()));
            CreateMap<DeleteCompanyHandlerOutput, DeleteCompanyEndPointResponse>()
               .ConstructUsing(src => new DeleteCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
