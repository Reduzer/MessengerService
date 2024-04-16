using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace Login.Security
{
    internal class hashing
    {
        private string sStringToHash;

        SHA3_512 sha;

        public hashing()
        {

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
            returnVal = Encoding.UTF8.GetBytes(sStringToHash);

            sha.ComputeHash(returnVal);

            return returnVal;
        }
    }
}
