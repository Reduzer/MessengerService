using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Exceptions
{
    public class OverflowException : Exception
    {
        public OverflowException() :base() { }
        public OverflowException(string message) : base(message) { }
        public OverflowException(string message, Exception inner) : base(message, inner) { }
    }
}
