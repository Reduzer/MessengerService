using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using Login.Security.Hashing;
using Login.Security.Encrypion.Objects;

namespace Login.Security.Encrypion
{
    internal class encryptSym
    {
        private generateSalt GetSalt;


        public encryptSym()
        {
            GetSalt = new generateSalt();
        }

        public AESObject getEncryptetMessage(string sInput)
        {
            AESObject sReturnString = null;

            sReturnString = encryptSyme(sInput);

            return sReturnString;
        }



        private AESObject encryptSyme(string sInput)
        {
            AESObject sReturnObject;

<<<<<<< Updated upstream
            byte[] encryptedData;

=======
>>>>>>> Stashed changes
            using (Aes myAes = Aes.Create())
            {



                sReturnObject = new AESObject();
            }

            return sReturnObject;
        }


    }
}
