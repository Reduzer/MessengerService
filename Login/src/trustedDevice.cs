using Login.Exceptions;
using Login.Objects;
using Login.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Login.src
{
    internal class trustedDevice
    {
        private SqlHandler m_handler;
        private macObject m_macObject;

        private string sMacAdress;

        private string sUserName;
        private string sPassword;

        private List<string> vs_Infos = new List<string>();

        public trustedDevice()
        {
            m_handler = new SqlHandler();
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
            try
            {
                m_macObject = m_handler.checkMac(sMacAdress);

                if (m_macObject != null)
                {


                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (macAdressException e)
            {
                Debug.WriteLine(e.ToString);
                return false;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString);
                return false;
            }
            
        }

        private bool getUserAccount()
        {
            


            return true;
        }
    }
}
