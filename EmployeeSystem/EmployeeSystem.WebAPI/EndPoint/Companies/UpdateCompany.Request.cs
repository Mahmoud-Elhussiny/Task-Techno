using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class UpdateCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/UpdateCompany/";

        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
