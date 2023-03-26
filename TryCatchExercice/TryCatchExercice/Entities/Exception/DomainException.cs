using System;

namespace TryCatchExercice.Entities.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(String msg)
            : base(msg)
        {
        }
    }
}
