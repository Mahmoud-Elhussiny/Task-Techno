using EmployeeSystem.Aplication.Business.Departments.Quary;
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetAllDepartmentsEndPointResponse : BaseRessponse
    {
        public GetAllDepartmentsEndPointResponse() { }
        public GetAllDepartmentsEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<AllDeparts> allDeparts { get; set; }
    }
}
