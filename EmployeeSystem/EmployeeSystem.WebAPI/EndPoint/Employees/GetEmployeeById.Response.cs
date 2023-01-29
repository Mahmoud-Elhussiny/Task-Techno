using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetEmployeeByIdEndPointResponse : BaseRessponse
    {
        public GetEmployeeByIdEndPointResponse() { }
        public GetEmployeeByIdEndPointResponse(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string UserName { get; set; } = "";

        public string password { get; set; } = "";

        public string? address { get; set; }

        public bool isAdmin { get; set; }
    }
}
