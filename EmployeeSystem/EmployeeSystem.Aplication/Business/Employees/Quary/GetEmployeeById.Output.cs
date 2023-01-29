using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetEmployeeByIdHandlerOutput : BaseRessponse
    {
        public GetEmployeeByIdHandlerOutput() { }
        public GetEmployeeByIdHandlerOutput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string UserName { get; set; } = "";

        public string password { get; set; } = "";

        public string? address { get; set; }

        public bool isAdmin { get; set; }
    }
}
