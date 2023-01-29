using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class CreateCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreateCompany/";

        public string Name { get; set; }
    }
}
