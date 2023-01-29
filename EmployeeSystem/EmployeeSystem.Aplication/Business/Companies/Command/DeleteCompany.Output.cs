
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class DeleteCompanyHandlerOutput : BaseRessponse
    {
        public DeleteCompanyHandlerOutput() { }
        public DeleteCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }


        public string Messages { get; set; }
    }
}
