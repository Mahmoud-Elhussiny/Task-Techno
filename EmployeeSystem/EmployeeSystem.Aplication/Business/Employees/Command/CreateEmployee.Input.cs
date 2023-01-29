using EmployeeSystem.Aplication.Messages;
using MediatR;

namespace EmployeeSystem.Aplication.Business.Employees.Command
{
    public class CreateEmployeeHandlerInput : BaseRequest, IRequest<CreateEmployeeHandlerOutput>
    {
        public CreateEmployeeHandlerInput() { }
        public CreateEmployeeHandlerInput(Guid correlationId) : base(correlationId) { }
        
        public string Name { get; set; } = "";

        
        public string UserName { get; set; } = "";
        public string password { get; set; } = "";

        public string? address { get; set; }

        public bool isAdmin { get; set; }

        public List<int> Departments_Id { get; set; } = null!;

    }
}
