using Networking;
using System;
using System.Diagnostics;

using networking.Client;
using networking.Server;

using System.Windows;

namespace networking
{
    public class networking : IDisposable
    {
        private static ClientHandler m_client = new ClientHandler();
        private static ServerHandler m_server = new ServerHandler();

        private static bool bConnectionEstablished;
        private bool _disposedValue;

        public static void Main()
        {
            testConnection();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed) 
            {
            
            }

            if (disposing)
            {

            
            }
            
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
                
            }
        }
    }
}

