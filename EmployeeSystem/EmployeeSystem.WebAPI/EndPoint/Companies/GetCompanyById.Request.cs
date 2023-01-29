using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetCompanyByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetCompanyById/";


        public int Id { get; set; }
    }
}
