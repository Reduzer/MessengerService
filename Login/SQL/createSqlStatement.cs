using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.SQL
{
    internal class createSqlStatement
    {
        private unsafe string sUserName;
        
        public unsafe string createStatement(string name)
        {
            string returnString;

            this.sUserName = name;

            returnString = "SELECT password FROM users WHERE name = " + sUserName;
  
            return returnString;
        }
    }
}
