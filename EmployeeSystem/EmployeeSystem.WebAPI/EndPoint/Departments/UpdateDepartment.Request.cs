using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class UpdateDepartmentEndPointRequest : BaseRequest
    {
        public const string Route = "/api/UpdateDepartment/";


        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CompanyId { get; set; }

    }
}
