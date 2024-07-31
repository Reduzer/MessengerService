using Login.Enums;
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
                return false;
            }
            
            return false;
        }

        private void readInfo()
        {
            //Remove the Magic string later
            sMacAddress = m_readJSON.readJSON(JSONEnums.mac.ToString());
            sSafedAccountName = m_readJSON.readJSON(JSONEnums.name.ToString());
            sSafedPassword = m_readJSON.readJSON(JSONEnums.password.ToString());
            sSafedUUID = m_readJSON.readJSON(JSONEnums.uuid.ToString());
        }

        public void firstTimeSetup(string name, string password, string mac, string uuid)
        {
            m_safeUserInfo.SafeInfo(name, password, mac, uuid);

            hasAlreadyBeenSafed = true;
        }
    }
}
