using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Security.Encrypion;
using Login.Security.Hashing;

namespace Login.Security
{
    internal class securityHandler
    {
        private encryptAsym m_encryptAsym;
        private encryptSym m_encryptSym;
        private hashing m_hashing;

        private string _sName;
        private string _sPassword;

        public securityHandler()
        {
            m_encryptAsym = new encryptAsym();
            m_encryptSym = new encryptSym();
            m_hashing = new hashing();
        }

        public Dictionary<string, string> getSecure(string name, string password, Point MousePosition)
        {
            Dictionary<string, string> returnVal = new Dictionary<string, string>();
            m_hashing.setMousePosition(MousePosition);



            


            return returnVal;
        }
    }
}
