using System;

namespace ReservationException.Entities.Exceptions
{
    class DomainException : AccessViolationException
    {
        public DomainException(string message): base (message)
        {
        }
    }
}
