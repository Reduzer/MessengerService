namespace networking.Client.Send;

public class check
{
    private string sIPAddress;
    private string sMessage;

    private int nPort;
    
    public check()
    {
        
    }

    public bool checkInput(string ipAddress, int port, string message)
    {
        this.nPort = port;
        this.sMessage = message;
        this.sIPAddress = ipAddress;
        
        return bCheck();
    }

    private bool bCheck()
    {
        
        
        return false;
    }
}