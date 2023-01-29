
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Departments.Quary
{
    public class GetDepartmentByIdHandlerOutput : BaseRessponse
    {
        public GetDepartmentByIdHandlerOutput() { }
        public GetDepartmentByIdHandlerOutput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string Name { get; set; }

        public int CompanyId { get; set; }

    }
}
