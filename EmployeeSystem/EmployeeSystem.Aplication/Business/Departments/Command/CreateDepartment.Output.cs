
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class CreateDepartmentHandlerOutput : BaseRessponse
    {
        public CreateDepartmentHandlerOutput() { }
        public CreateDepartmentHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }

    }
}
