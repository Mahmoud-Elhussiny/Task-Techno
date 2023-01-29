using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Quary;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetAllCompaniesMapper : Profile
    {
        public GetAllCompaniesMapper()
        {
            CreateMap<GetAllCompaniesEndPointRequest, GetAllCompaniesHandlerInput>()
                .ConstructUsing(src => new GetAllCompaniesHandlerInput(src.CorrelationId()));
            CreateMap<GetAllCompaniesHandlerOutput, GetAllCompaniesEndPointResponse>()
               .ConstructUsing(src => new GetAllCompaniesEndPointResponse(src.CorrelationId()));
        }

    }
}
