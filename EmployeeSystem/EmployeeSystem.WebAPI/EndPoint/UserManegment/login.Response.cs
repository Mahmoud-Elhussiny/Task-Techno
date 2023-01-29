using EmployeeSystem.Aplication.Business.UserManegment.Command;
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.WebAPI.EndPoint.UserManegment
{
    public class loginEndPointResponse : BaseRessponse
    {
        public loginEndPointResponse() { }
        public loginEndPointResponse(Guid correlationId) : base(correlationId) { }

        public ActiveContext activeContext { get; set; }
    }
}
