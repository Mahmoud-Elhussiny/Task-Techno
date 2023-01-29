
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class UpdateCompanyEndPointResponse : BaseRessponse
    {
        public UpdateCompanyEndPointResponse() { }
        public UpdateCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
