using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExceptions.Entities.Domain
{
    class DomainException : AccessViolationException
    {
        public DomainException(string message): base (message)
        {
        }
    }
}
