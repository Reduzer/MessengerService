using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Exceptions
{
    internal class JSONDoesNotExistException : Exception
    {
        public JSONDoesNotExistException() : base() { }
        public JSONDoesNotExistException(string message) : base(message) { }
        public JSONDoesNotExistException(string message, Exception inner) : base(message, inner) { }
    }
}
