using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Security.Cryptography;

namespace Login.Security
{
    internal class encryptAsym
    {
        private RSA m_rsa;
        private string sMessage;

        private string skey;

        public encryptAsym()
        {
            
        }

        public void encryptData(string message, string key)
        {
            this.sMessage = message;
            this.skey = key;
        }
    }
}
