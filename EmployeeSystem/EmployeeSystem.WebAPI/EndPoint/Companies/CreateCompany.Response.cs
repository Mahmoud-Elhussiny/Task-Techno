
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class CreateCompanyEndPointResponse : BaseRessponse
    {
        public CreateCompanyEndPointResponse() { }
        public CreateCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }

    }
}
