using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Networking;

using Login.Objects;

namespace Login.SQL
{
    internal class SqlHandler
    {
        private createSqlStatement m_sqlStatement;
        private checkIfSafe m_checkIfSafe;

        private unsafe string sUserName;
        private unsafe string sUserPassword;

        private readonly string userType = "user";
        private readonly string macType = "mac";

        private string loginType = "login";

        public SqlHandler() 
        {
            m_sqlStatement = new createSqlStatement();
            m_checkIfSafe = new checkIfSafe();
        }

        public bool Sql(string name, string password)
        {
            this.sUserName = name;
            this.sUserPassword = password;

            if (check())
            {
                networking.networking.sendMessageToServer(getSQLStatement(userType), loginType);
                return true;
            }
            else
            {
                return false;
            }
        }


        private unsafe bool check()
        {
            if(m_checkIfSafe.isSafe(sUserName, sUserPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool macIsKnown()
        {
            return false;
        }

        private macObject getMacObject()
        {
            return null;
        }


        public macObject checkMac(string macAdress)
        {
            if (macIsKnown())
            {
                return getMacObject();
            }
            else
            {
                return null;
            }
        }

        private unsafe string getSQLStatement(string requester)
        {
            string sReturnString;

            if (requester == "username")
            {
               sReturnString = m_sqlStatement.createStatement("user");
            }
            else
            {
                sReturnString = m_sqlStatement.createStatement("mac");
            }
             
            return sReturnString;
        }

    }
}
