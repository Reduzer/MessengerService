using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Login.TrustedDevice
{
    internal class Mac
    {
        public Mac() 
        {
        
        }

        public string? getCurrentMac()
        {
            var macAddress = 
                (
                    from nic in NetworkInterface.GetAllNetworkInterfaces()
                    where nic.OperationalStatus == OperationalStatus.Up
                    select nic.GetPhysicalAddress().ToString()
                ).FirstOrDefault();

            return macAddress;
        }
    }
}
