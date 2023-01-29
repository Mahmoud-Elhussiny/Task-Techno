using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class CreateEmployeeEndPointRequest : BaseRequest
    {
        public const string Route = "/api/CreateEmployee/";

        public string Name { get; set; } = "";

        public string UserName { get; set; } = "";
        public string password { get; set; } = "";

        public string? address { get; set; }

        public bool isAdmin { get; set; }

        public List<int> Departments_Id { get; set; } = null!;

    }
}
