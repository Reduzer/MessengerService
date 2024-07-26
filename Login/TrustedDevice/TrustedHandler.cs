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



        public TrustedHandler() 
        {

        }

        public bool CheckForTrusted()
        {
            if (hasAlreadyBeenSafed)
            {
                readInfo();
            }
            else
            {

            }
            
            return false;
        }

        private void readInfo()
        {

        }

        private void firstTimeSetup()
        {

        }
    }
}
