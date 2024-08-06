using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Networking;

namespace Login.SQL
{
    internal class SqlHandler
    {
        private checkIfSafe m_checkIfSafe;

        private readonly string userType = "user";
        private readonly string macType = "mac";

        private string loginType = "login";

        public SqlHandler() 
        {
            m_checkIfSafe = new checkIfSafe();
        }

        public bool checkForSafety(string name, string password)
        {
            if(m_checkIfSafe.isSafe(name, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
