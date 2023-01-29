using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Aplication.Messages
{
    public abstract class BaseRequest:BaseMasseges
    {
        public BaseRequest() { }
        public BaseRequest(Guid correlationId) : base()
        {
            _correlationId = correlationId;
        }
    }
}
