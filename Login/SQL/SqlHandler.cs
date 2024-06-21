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

        private unsafe string* sUserName;
        private unsafe string* sUserPassword;

        private string loginType = "login";

        public SqlHandler() 
        {
            m_sqlStatement = new createSqlStatement();
            m_checkIfSafe = new checkIfSafe();
        }

        public unsafe bool Sql(string* name, string* password)
        {
            this.sUserName = name;
            this.sUserPassword = password;

            if (check())
            {
                networking.networking.sendMessageToServer(getSQLStatement(), loginType);
                return true;
            }
            else
            {
                return false;
            }
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

        private unsafe string getSQLStatement()
        {
            string returnstring = m_sqlStatement.createStatement(sUserName);
            return returnstring;
        }

    }
}
