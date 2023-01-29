
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class UpdateEmployeeHandlerOutput : BaseRessponse
    {
        public UpdateEmployeeHandlerOutput() { }
        public UpdateEmployeeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
