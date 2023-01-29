
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Departments.Command
{
    public class UpdateDepartmentHandlerOutput : BaseRessponse
    {
        public UpdateDepartmentHandlerOutput() { }
        public UpdateDepartmentHandlerOutput(Guid correlationId) : base(correlationId) { }


        public string Messages { get; set; }

    }
}
