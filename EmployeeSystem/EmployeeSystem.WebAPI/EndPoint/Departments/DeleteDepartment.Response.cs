
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class DeleteDepartmentEndPointResponse : BaseRessponse
    {
        public DeleteDepartmentEndPointResponse() { }
        public DeleteDepartmentEndPointResponse(Guid correlationId) : base(correlationId) { }


        public string Messages { get; set; }

    }
}
