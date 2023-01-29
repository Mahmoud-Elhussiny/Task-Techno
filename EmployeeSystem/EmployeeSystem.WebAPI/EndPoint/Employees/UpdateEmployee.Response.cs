using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class UpdateEmployeeEndPointResponse : BaseRessponse
    {
        public UpdateEmployeeEndPointResponse() { }
        public UpdateEmployeeEndPointResponse(Guid correlationId) : base(correlationId) { }


        public string Messages { get; set; }
    }
}
