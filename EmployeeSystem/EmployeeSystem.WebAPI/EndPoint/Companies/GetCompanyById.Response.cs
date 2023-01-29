using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetCompanyByIdEndPointResponse : BaseRessponse
    {
        public GetCompanyByIdEndPointResponse() { }
        public GetCompanyByIdEndPointResponse(Guid correlationId) : base(correlationId) { }


        public int Id { get; set; }
        public string Name { get; set; }
    }
}
