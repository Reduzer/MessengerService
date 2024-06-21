using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Exceptions
{
    public class macAdressException : Exception
    {
        public macAdressException() : base() { }
        public macAdressException(string message) : base(message) { }
        public macAdressException(string message, Exception inner) : base(message, inner) { }
    }
}
