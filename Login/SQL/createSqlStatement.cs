using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.SQL
{
    internal class createSqlStatement
    {
        private string type;
        private string target;


        public createSqlStatement()
        {

        }

        public string createStatement(string type, string target, string input)
        {
            string returnString;

            returnString = "SELECT " + type + " FROM users WHERE " + target + " = '" + input + "'";


            return null;
        }
    }
}
