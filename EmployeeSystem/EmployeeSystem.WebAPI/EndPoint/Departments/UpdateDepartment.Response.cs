using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class UpdateDepartmentEndPointResponse : BaseRessponse
    {
        public UpdateDepartmentEndPointResponse() { }
        public UpdateDepartmentEndPointResponse(Guid correlationId) : base(correlationId) { }


        public string Messages { get; set; }

    }
}
