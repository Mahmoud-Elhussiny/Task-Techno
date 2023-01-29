using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class DeleteCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteCompany/";


        public int Id { get; set; }
    }
}
