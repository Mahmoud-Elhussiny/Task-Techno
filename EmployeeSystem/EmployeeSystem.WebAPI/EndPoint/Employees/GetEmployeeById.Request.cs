using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetEmployeeByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetEmployeeById/";


        public int Id { get; set; }

    }
}
