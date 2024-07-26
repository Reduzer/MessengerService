using Login.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.TrustedDevice
{
    internal class SafeUserInfo
    {
        private Mac m_Mac;
        private CreateJSON m_CreateJSON;
        private WriteToJSON m_WriteJSON;

        public SafeUserInfo() 
        {
            m_Mac = new Mac();
            m_CreateJSON = new CreateJSON();
            m_WriteJSON = new WriteToJSON();
        }

        public bool SafeInfo(string name, string password)
        {



            return false;
        }
    }
}
