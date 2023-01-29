using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class CreateEmployeeHandlerOutput : BaseRessponse
    {
        public CreateEmployeeHandlerOutput() { }
        public CreateEmployeeHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
