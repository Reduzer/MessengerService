using Login.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.TrustedDevice
{
    internal class TrustedHandler
    {
        private bool hasAlreadyBeenSafed = false;

        private string? sMacAddress;
        private string? sSafedAccountName;
        private string? sSafedPassword;
        private string? sSafedUUID;

        private ReadJSON m_readJSON;
        private SafeUserInfo m_safeUserInfo;

        public TrustedHandler() 
        {
            m_readJSON = new ReadJSON();
            m_safeUserInfo = new SafeUserInfo();
        }

        public bool CheckForTrusted()
        {
            if (hasAlreadyBeenSafed)
            {
                readInfo();

                networking.Networking.sendMessageToServer("user", "login");
            }
            else
            {

            }
            
            return false;
        }

        private void readInfo()
        {
            //Remove the Magic string later
            sMacAddress = m_readJSON.readJSON("MacAddress");
            sSafedAccountName = m_readJSON.readJSON("Name");
            sSafedPassword = m_readJSON.readJSON("Password");
            sSafedUUID = m_readJSON.readJSON("UUID");
        }

        private void firstTimeSetup()
        {
            //m_safeUserInfo.SafeInfo();
        }
    }
}
