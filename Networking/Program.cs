using Networking;
using System;
using System.Diagnostics;

using networking.Client;
using networking.Server;

namespace networking
{
    public class networking
    {
        private static ClientHandler m_client = new ClientHandler();
        private static ServerHandler m_server = new ServerHandler();
        
        public static void Main()
        {
            testConnection();
        }

        private static void testConnection()
        {
            m_client.sendMessageToServer("Connection Test", "Test");
            m_server.getServerResponse();
        }
        
        public static void sendMessageToServer(string message, string type)
        {
            sendMessageToServer(message, type);
        }
    }
}

