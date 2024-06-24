using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

using Login.Security;

namespace Login.Security
{
    internal class encryptSym
    {
        private generateSalt GetSalt;


        public encryptSym()
        {
            GetSalt = new generateSalt();
        }

        public string getEncryptetMessage(string sInput)
        {
            string sReturnString = "";

            sReturnString = encryptSyme(sInput);

            return sReturnString;
        }


        
        private string encryptSyme(string sInput)
        {
            string sReturnString = String.Empty;

            string salt = Convert.ToBase64String(GetSalt.getSalt());

            using (Aes myAes = Aes.Create())
            {
                sReturnString = sInput;


            }
            
            return sReturnString;
        }
        

    }
}
