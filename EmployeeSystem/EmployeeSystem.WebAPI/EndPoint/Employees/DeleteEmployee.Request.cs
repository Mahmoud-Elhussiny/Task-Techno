using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class DeleteEmployeeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteEmployee/";


        public int Id { get; set; }
    }
}
