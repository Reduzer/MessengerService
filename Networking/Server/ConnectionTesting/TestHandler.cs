using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.ConnectionTesting
{
    internal class TestHandler
    {
        private pingServer ping;
        private SendTestMessage SendTestMessage;

        public TestHandler()
        {
            ping = new pingServer();
            SendTestMessage = new SendTestMessage();
        }

        public bool testConnection()
        {
            return false;
        }
    }
}
