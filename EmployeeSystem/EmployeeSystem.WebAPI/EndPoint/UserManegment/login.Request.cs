using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.UserManegment
{
    public class loginEndPointRequest : BaseRequest
    {
        public const string Route = "/api/login/";

        public string UserName { get; set; }

        public string password { get; set; }
    }
}
