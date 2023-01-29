using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Aplication.Messages
{
    public abstract class BaseMasseges
    {
        protected Guid _correlationId = Guid.NewGuid();
        public Guid CorrelationId() => _correlationId;
    }
}
