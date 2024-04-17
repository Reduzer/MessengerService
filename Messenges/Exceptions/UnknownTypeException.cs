using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenges.Exceptions
{
    /// <summary>
    /// The given Type is not known by the Program.
    /// </summary>
    public class UnknownTypeException : Exception
    {
        public UnknownTypeException() : base() { }
        public UnknownTypeException(string message) : base(message) { }
        public UnknownTypeException(string message, Exception inner) : base(message, inner) { }

    }
}
