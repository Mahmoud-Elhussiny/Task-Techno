using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class CreateDepartmentEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreateDepartment/";


        public string Name { get; set; }
        public int CompanyId { get; set; }

    }
}
