using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Security
{
    internal class securityHandler
    {
        private encryptAsym encryptAsym;
        private encryptSym encryptSym;
        private hashing hashing;

        private string name;
        private string password;

        public securityHandler()
        {
            encryptAsym = new encryptAsym();
            encryptSym = new encryptSym();
            hashing = new hashing();
        }

        public string getSecure(string input)
        {
            string returnString;

            returnString = input;

            returnString = hashing.hash(returnString).ToString();


            return returnString;
        }

    }
}
