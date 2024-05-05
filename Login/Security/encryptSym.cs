using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;


namespace Login.Security
{
    internal class encryptSym
    {
        public encryptSym()
        {

        }

        public string getEncryptetMessage(string sInput)
        {
            string sReturnString = "";

            sReturnString = encryptSym(sInput);

            return sReturnString;
        }

        private string encryptSym(string sInput)
        {

        }


    }
}
