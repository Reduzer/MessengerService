using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.Drawing;

namespace Login.Security.Hashing
{
    internal class hashing
    {
        private string sStringToHash;

        private SHA3_512 sha;
        private generateSalt salt;

        private salt generatetSalt;

        public hashing()
        {
            salt = new generateSalt();
        }

        public byte[] hash(string sStringToHash)
        {
            this.sStringToHash = sStringToHash;

            byte[] returnVal = hashString();

            return returnVal;
        }

        private byte[] hashString()
        {
            byte[] returnVal;

            sha = SHA3_512.Create();

            generatetSalt = salt.getSalt();

            returnVal = Encoding.UTF8.GetBytes(generatetSalt._sDateTime + sStringToHash + generatetSalt._sMouseCoordinates);

            sha.ComputeHash(returnVal);

            return returnVal;
        }

        public void setMousePosition(Point MousePosition)
        {
            salt.setMousePosition(MousePosition);
        }
    }
}
