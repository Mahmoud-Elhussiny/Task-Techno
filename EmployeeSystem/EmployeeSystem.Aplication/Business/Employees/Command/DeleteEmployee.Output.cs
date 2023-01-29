using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class DeleteEmployeeHandlerOutput : BaseRessponse
    {
        public DeleteEmployeeHandlerOutput() { }
        public DeleteEmployeeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
