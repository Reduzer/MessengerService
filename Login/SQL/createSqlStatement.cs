using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.SQL
{
    internal class createSqlStatement
    {
        private string sUserName;
        private string sMacAddress;
        
        public string createStatement(string name)
        {
            string returnString;

            this.sUserName = name;

            returnString = "SELECT password FROM users WHERE name = '" + sUserName + "'";
  
            return returnString;
        }

        public string MacAdressStatement(string macAdress)
        {
            string returnString;

            this.sMacAddress = macAdress;

            returnString = "SELECT userID FROM trusteddevices WHERE macaddress = '" + sMacAddress + "'";

            return returnString;
        }
    }

    
}
