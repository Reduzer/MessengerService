using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Login.Objects
{
    internal class macObject
    {
        private string macNumber;
        private string userName;
        private string password;

        public macObject(string macNumber, string userName, string password) 
        {
            this.macNumber = macNumber;
            this.userName = userName;
            this.password = password;
        }

        public string MacNumber
        {  
            get { return macNumber; }
        }

        public string UserName
        {
            get { return userName; }
        }

        public string Password
        {
            get { return password; }
        }

    }
}
