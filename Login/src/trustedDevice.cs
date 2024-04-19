using Login.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Login.src
{
    internal class trustedDevice
    {
        private SqlHandler handler;

        private string sMacAdress;
        private bool bIsKnown;

        private string sUserName;
        private string sPassword;

        private List<string> vs_Infos = new List<string>();

        public trustedDevice()
        {
            handler = new SqlHandler();
        }

        public List<string> isDeviceKnown()
        {
            getMac();

            if (sqlRequest())
            {
                return vs_Infos;
            }
            else
            {
                return null;
            }          
        }

        private void getMac()
        {
            var mac = (from nic in NetworkInterface.GetAllNetworkInterfaces()
                       where nic.OperationalStatus == OperationalStatus.Up
                       select nic.GetPhysicalAddress().ToString());

            sMacAdress = mac.ToString();
        }

        private bool sqlRequest()
        {
            if (handler.checkMac(sMacAdress))
            {


                return true;
            }
            else
            {
                return false;
            }
        }

        private bool getUserAccount()
        {
            


            return true;
        }

        private bool accountIsKnown()
        {
            vs_Infos.Add(sUserName);
            vs_Infos.Add(sPassword);

            return true;
        }
    }
}
