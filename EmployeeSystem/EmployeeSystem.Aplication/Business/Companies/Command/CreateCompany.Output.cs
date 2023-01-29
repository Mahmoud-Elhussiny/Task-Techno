
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class CreateCompanyHandlerOutput : BaseRessponse
    {
        public CreateCompanyHandlerOutput() { }
        public CreateCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }
        
        
        public string Messages { get; set; }
    }
}
