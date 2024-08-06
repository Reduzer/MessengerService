using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Exceptions
{
    public class SafetyNowMatchedExceptions : Exception
    {
        public SafetyNowMatchedExceptions() : base() { }
        public SafetyNowMatchedExceptions(string message) : base(message) { }
        public SafetyNowMatchedExceptions(string message, Exception inner) : base(message, inner) { }

    }
}
