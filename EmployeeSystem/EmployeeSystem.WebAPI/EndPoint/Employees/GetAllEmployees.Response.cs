using EmployeeSystem.Aplication.Business.Employees.Quary;
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetAllEmployeesEndPointResponse : BaseRessponse
    {
        public GetAllEmployeesEndPointResponse() { }
        public GetAllEmployeesEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<AllEmployees> allEmployees { get; set; }
    }
}
