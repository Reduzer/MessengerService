using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Objects
{
    internal class secureObject
    {
        private string password;
        private string salt;

        public secureObject() 
        { 
        
        }

        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
    }
}
