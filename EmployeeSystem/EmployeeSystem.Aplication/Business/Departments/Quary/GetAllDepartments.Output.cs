
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Departments.Quary
{
    public class GetAllDepartmentsHandlerOutput : BaseRessponse
    {
        public GetAllDepartmentsHandlerOutput() { }
        public GetAllDepartmentsHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<AllDeparts> allDeparts { get; set; }

    }
    public class AllDeparts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }

    }

}
