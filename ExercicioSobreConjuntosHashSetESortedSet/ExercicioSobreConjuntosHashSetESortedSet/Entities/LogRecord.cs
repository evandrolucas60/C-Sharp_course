using System;
using System.Collections.Generic;

namespace ExercicioSobreConjuntosHashSetESortedSet.Entities
{
    class LogRecord
    {
        public String UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            LogRecord otter = obj as LogRecord;
            return UserName.Equals(otter.UserName);
        }
    }
}
