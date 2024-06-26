using Networking;
using System;
using System.Diagnostics;

using networking.Client;
using networking.Server;

using System.Windows;


namespace networking
{
    public class networking
    {
        private static ClientHandler m_client = new ClientHandler();
        private static ServerHandler m_server = new ServerHandler();
        
        public static void Main()
        {
            if (testConnection())
            {

            }
        }

        private static bool testConnection()
        {
            try
            {
                m_client.sendMessageToServer("Connection Test", "Test");
                m_server.getServerResponse();

                return true;
            }
            catch (ConnectionErrorException e)
            {
                return false;
            }
        }
        
        public static void sendMessageToServer(string message, string type)
        {
            try
            {
                m_client.sendMessageToServer(message, type);
            }
            catch(Exception e){
                       
            }
        }
    }
}

