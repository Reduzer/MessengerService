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
<<<<<<< HEAD
        private string type;
        private string target;

=======
        string type;
>>>>>>> 6f86a6dc8e5e3d284e469a4d280206ee882d32dd

        public createSqlStatement()
        {

        }

<<<<<<< HEAD
        public string createStatement(string type, string target, string input)
        {
            string returnString;

            returnString = "SELECT " + type + " FROM users WHERE " + target + " = '" + input + "'";


            return null;
=======
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
>>>>>>> 6f86a6dc8e5e3d284e469a4d280206ee882d32dd
        }
    }
}
