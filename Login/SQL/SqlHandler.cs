using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Login.Objects;

namespace Login.SQL
{
    internal class SqlHandler
    {

        private checkIfSafe checkIfSafe;
        private createSqlStatement createSqlStatement;
        private getInfo getInfo;

        private unsafe string* sUserName;
        private unsafe string* sUserPassword;

        public SqlHandler() 
        {
            checkIfSafe = new checkIfSafe();
            createSqlStatement = new createSqlStatement();
            getInfo = new getInfo();
        }

        public unsafe bool Sql(string* name, string* password)
        {
            this.sUserName = name;
            this.sUserPassword = password;

            if (check())
            {
                if (sendToDataBase())
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

            }
            else 
            {
                return null;
            }
        }

        private unsafe bool check()
        {
            if(checkIfSafe.isSafe(sUserName, sUserPassword))
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

        private bool sendToDataBase()
        {


            return false;
        }

    }
}
