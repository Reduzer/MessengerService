using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Exceptions
{
    public class IllegalSqlCommandException : Exception
    {
        public IllegalSqlCommandException() : base() { }
        public IllegalSqlCommandException(string message) : base(message) { }
        public IllegalSqlCommandException(string message, Exception inner) : base(message, inner) { }
    }
}
