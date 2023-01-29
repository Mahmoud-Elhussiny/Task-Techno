using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class DeleteCompanyEndPointResponse : BaseRessponse
    {
        public DeleteCompanyEndPointResponse() { }
        public DeleteCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
