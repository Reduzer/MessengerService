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

        private JSONHandler m_jsonHandler;

        public TrustedHandler() 
        {
            m_jsonHandler = new JSONHandler();
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
            Dictionary<string, string> safedInfo = m_jsonHandler.readJSON();

        }

        public void firstTimeSetup(string name, string password, string mac, string uuid)
        {
            string[] infos = [name, password, mac, uuid];
            m_jsonHandler.firstTimeSetup(infos);

            hasAlreadyBeenSafed = true;
        }
    }
}
