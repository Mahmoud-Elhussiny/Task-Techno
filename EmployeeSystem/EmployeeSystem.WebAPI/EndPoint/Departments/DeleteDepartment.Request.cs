using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class DeleteDepartmentEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteDepartment/";

        public int Id { get; set; }
    }
}
