
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class CreateDepartmentEndPointResponse : BaseRessponse
    {
        public CreateDepartmentEndPointResponse() { }
        public CreateDepartmentEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
