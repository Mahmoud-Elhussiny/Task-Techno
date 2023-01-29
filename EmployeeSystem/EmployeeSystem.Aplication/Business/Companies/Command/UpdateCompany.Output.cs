
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Companies.Command
{
    public class UpdateCompanyHandlerOutput : BaseRessponse
    {
        public UpdateCompanyHandlerOutput() { }
        public UpdateCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }

        public string Messages { get; set; }
    }
}
