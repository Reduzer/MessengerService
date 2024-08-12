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

            byte[] encryptedData;

            using (Aes myAes = Aes.Create())
            {
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                using(MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(sInput);
                        }
                        encryptedData = memStream.ToArray();
                    }
                }

                sReturnObject = new AESObject(encryptedData, myAes.Key, myAes.IV);
            }

            return sReturnObject;
        }


    }
}
