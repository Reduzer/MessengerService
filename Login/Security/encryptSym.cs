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

            sReturnString = encryptSyme(sInput);

            return sReturnString;
        }


        
        private string encryptSyme(string sInput)
        {
            string sReturnString = "";

            using (Aes myAes = Aes.Create())
            {
                sReturnString = sInput;


            }
            
            return sReturnString;
        }
        

    }
}
