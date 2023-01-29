
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class DeleteDepartmentHandlerOutput : BaseRessponse
    {
        public DeleteDepartmentHandlerOutput() { }
        public DeleteDepartmentHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }

    }
}
