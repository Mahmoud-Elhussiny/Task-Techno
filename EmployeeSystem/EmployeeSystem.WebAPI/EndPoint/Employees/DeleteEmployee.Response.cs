using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class DeleteEmployeeEndPointResponse : BaseRessponse
    {
        public DeleteEmployeeEndPointResponse() { }
        public DeleteEmployeeEndPointResponse(Guid correlationId) : base(correlationId) { }


        public string Messages { get; set; }
    }
}
