using System;
using System.Net.Sockets;
using System.Text;

namespace networking.Client;

public class ClientHandler
{
    private send m_send;

    private string sMessage;
    private string sType;

    public ClientHandler()
    {
        m_send = new send();
    }

    public void sendMessageToServer(string message, string type)
    {
        sMessage = message;
        sType = type;

        m_send.sendMessage(sMessage, type);
    }
}