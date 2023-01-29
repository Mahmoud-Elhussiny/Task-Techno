using AutoMapper;
using EmployeeSystem.Aplication.Business.UserManegment.Command;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.UserManegment
{
    public class loginMapper : Profile
    {
        public loginMapper()
        {
            CreateMap<loginEndPointRequest, loginHandlerInput>()
                .ConstructUsing(src => new loginHandlerInput(src.CorrelationId()));
            CreateMap<loginHandlerOutput, loginEndPointResponse>()
               .ConstructUsing(src => new loginEndPointResponse(src.CorrelationId()));
        }

    }
}
