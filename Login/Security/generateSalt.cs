using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace Login.Security
{
    internal class generateSalt
    {

        public byte[] getSalt()
        {
            byte[] returnVal;

            using(var generator = RandomNumberGenerator.Create())
            {
                var salt = new byte[128];
                generator.GetBytes(salt);
                returnVal = salt;
            }

            return returnVal;
        }

    }
}
