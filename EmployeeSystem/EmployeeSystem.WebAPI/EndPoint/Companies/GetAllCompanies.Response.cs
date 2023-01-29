using EmployeeSystem.Aplication.Business.Companies.Quary;
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetAllCompaniesEndPointResponse : BaseRessponse
    {
        public GetAllCompaniesEndPointResponse() { }
        public GetAllCompaniesEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<allcompany> allcompanies { get; set; }
    }
}
