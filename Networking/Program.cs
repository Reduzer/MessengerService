using Networking.ConnectionTesting;
using System;
using System.Diagnostics;

namespace networking
{
    public class networking
    {
        private static TestHandler tests = new TestHandler();

        public static void Main()
        {
            if (testConnection())
            {
                Debug.WriteLine("Connection established");
            }
            else
            {
                Debug.WriteLine("Connection failed");
            }
        }

        private static bool testConnection()  
        {
            if (tests.testConnection())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void sendMessage()
        {

        }
    }
}

