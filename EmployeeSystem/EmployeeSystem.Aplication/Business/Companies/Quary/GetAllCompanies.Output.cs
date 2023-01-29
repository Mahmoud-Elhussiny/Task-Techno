
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.Companies.Quary
{
    public class GetAllCompaniesHandlerOutput : BaseRessponse
    {
        public GetAllCompaniesHandlerOutput() { }
        public GetAllCompaniesHandlerOutput(Guid correlationId) : base(correlationId) { }

        public List<allcompany> allcompanies { get; set; }
    }


    public class allcompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
