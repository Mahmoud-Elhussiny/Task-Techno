
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class CreateEmployeeEndPointResponse : BaseRessponse
    {
        public CreateEmployeeEndPointResponse() { }
        public CreateEmployeeEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
