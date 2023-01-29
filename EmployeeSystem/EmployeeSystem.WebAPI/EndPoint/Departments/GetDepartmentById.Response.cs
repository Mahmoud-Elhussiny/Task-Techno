
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetDepartmentByIdEndPointResponse : BaseRessponse
    {
        public GetDepartmentByIdEndPointResponse() { }
        public GetDepartmentByIdEndPointResponse(Guid correlationId) : base(correlationId) { }


        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }

    }
}
