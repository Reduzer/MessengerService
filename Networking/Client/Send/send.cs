using Networking;
using System.Net.Sockets;
using System.Text;

namespace networking.Client;

public class send
{
    private TcpClient m_tcpClient;
    private StreamReader m_reader;
    private StreamWriter m_writer;
    private string[] sData;

    //WICHTIG! Hier noch umbauen auf richtigen Server, aktuell wird dies nur lokal verwendet, daher hier die angaben
    private readonly string sServerIP = "192.168.178.37";
    private readonly int nServerPort = 5000;

    string sMessage, sType;
    
    public send()
    {
        m_tcpClient = new TcpClient();
        m_tcpClient.Connect(sServerIP, nServerPort);
    }

    //Public method for takin input from the user
    public void sendMessage(string message, string type)
    {
        this.sMessage = message;
        this.sType = type;
        handleCommunication();
    }

    //Comunicates with the Server
    private void handleCommunication()
    {
        try
        {
            m_reader = new StreamReader(m_tcpClient.GetStream(), Encoding.ASCII);
            m_writer = new StreamWriter(m_tcpClient.GetStream(), Encoding.ASCII);


            sData[0] = sType;
            sData[1] = sMessage;

            for (int i = 0; i < 2; i++)
            {
                m_writer.WriteLine(sData[i]);
                m_writer.Flush();
            }
        }
        catch (Exception e)
        {
            throw new ConnectionErrorException();
        }
        
    }
}