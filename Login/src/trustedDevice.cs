using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.src
{
    internal class trustedDevice
    {
        private string sMacAdress;
        private bool bIsKnown;

        private string sUserName;
        private string sPassword;

        private List<string> vs_Infos = new List<string>();

        public trustedDevice()
        {

        }

        public List<string> isDeviceKnown()
        {
            

            return vs_Infos;
        }



    }
}
