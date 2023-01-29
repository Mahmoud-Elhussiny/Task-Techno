
using EmployeeSystem.Aplication.Messages;
using EmployeeSystem.Domain;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetAllEmployeesHandlerOutput : BaseRessponse
    {
        public GetAllEmployeesHandlerOutput() { }
        public GetAllEmployeesHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<AllEmployees> allEmployees { get; set; }

    }

    public class AllEmployees
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string UserName { get; set; } = "";

        public string password { get; set; } = "";

        public string? address { get; set; }

        public bool isAdmin { get; set; }

        public List<string> DepartmentsName { get; set; }

    }
}
