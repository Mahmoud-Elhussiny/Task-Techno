using EmployeeSystem.Aplication.Messages;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Aplication.Business.UserManegment.Command
{
    public class loginHandlerInput : BaseRequest, IRequest<loginHandlerOutput>
    {
        public loginHandlerInput() { }
        public loginHandlerInput(Guid correlationId) : base(correlationId) { }

        public string UserName { get; set; }
        
        public string password { get; set; }

    }
}
