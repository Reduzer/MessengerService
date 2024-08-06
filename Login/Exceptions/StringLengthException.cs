using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Exceptions
{
    public class StringLengthException : Exception
    {
        public StringLengthException() : base() { }
        public StringLengthException(string message) : base(message) { }
        public StringLengthException(string message, Exception inner) : base(message, inner) { }
    }
}
