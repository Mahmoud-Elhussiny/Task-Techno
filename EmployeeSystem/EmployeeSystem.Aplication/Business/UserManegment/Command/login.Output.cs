
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.Aplication.Business.UserManegment.Command
{
    public class loginHandlerOutput : BaseRessponse
    {
        public loginHandlerOutput() { }
        public loginHandlerOutput(Guid correlationId) : base(correlationId) { }

        public ActiveContext activeContext { get; set; }

    }

    public class ActiveContext
    {
        public string message { get; set; }
        public bool IsAuthnticated { get; set; }
        public string Name { get; set; }
       
        public string token { get; set; }
        public DateTime expireson { get; set; }
    }
}
