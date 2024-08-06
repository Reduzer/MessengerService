using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Security.Encrypion.Objects
{
    internal class RSAObject
    {
        public byte[] message { get; private set; }
        public byte[] key { get; private set; }
        public byte[] iv { get; private set; }

        public RSAObject(byte[] msg, byte[] key, byte[] iv)
        {
            this.message = msg;
            this.key = key;
            this.iv = iv;
        }

    }
}
