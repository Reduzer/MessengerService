using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Security.Hashing
{
    internal class salt
    {
        public byte[] _sDateTime { get; private set; }
        public byte[] _sMouseCoordinates { get; private set; }

        public salt(string sDateTime, string sCoordinates)
        {
            getBytes(sDateTime, sCoordinates);
        }

        private void getBytes(string sDateTime, string sCoordinates)
        {
            this._sDateTime = Encoding.UTF8.GetBytes(sDateTime);
            this._sMouseCoordinates = Encoding.UTF8.GetBytes(sCoordinates);
        }
    }
}
