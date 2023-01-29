
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Companies.Quary
{
    public class GetCompanyByIdHandlerOutput : BaseRessponse
    {
        public GetCompanyByIdHandlerOutput() { }
        public GetCompanyByIdHandlerOutput(Guid correlationId) : base(correlationId) { }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
