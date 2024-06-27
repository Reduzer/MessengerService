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

        private static bool bConnectionEstablished;
        
        public static void Main()
        {
            testConnection();
        }

        private static bool testConnection()
        {
            try
            {
                m_client.sendMessageToServer("Connection Test", "Test");
                m_server.getServerResponse();

                bConnectionEstablished = true;

                return true;
            }
            catch (ConnectionErrorException e)
            {
                bConnectionEstablished = false;
                return false;
            }
        }
        
        public static void sendMessageToServer(string message, string type)
        {
            if (bConnectionEstablished)
            {
                try
                {
                    m_client.sendMessageToServer(message, type);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
            else
            {
                Viewer.MainWindow.ShowMessageBox();
            }
        }
    }
}

