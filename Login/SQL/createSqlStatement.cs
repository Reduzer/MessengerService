using Login.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.SQL
{
    internal class createSqlStatement
    {
        string type;

        public createSqlStatement()
        {

        }

        public string createSQLStatement(string type)
        {
            if (checkType(type))
            {
                return getPreparedStatement(type);
            }
            else
            {
                return String.Empty;
            }
        }

        private bool checkType(string type)
        {
            if (type == SQLTypes.Login.ToString() || type == SQLTypes.getMac.ToString() || type == SQLTypes.getUserInfo.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        private string getPreparedStatement(string type)
        {
            string returnString = "";

            if ()
            {


            }


            return returnString;
        }
    }
}
