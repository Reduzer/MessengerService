using System;
using System.Reflection.Metadata;
using Login.Exceptions;
using Login.Security;
using Login.SQL;
using Login.TrustedDevice;
using System.Diagnostics;
using Login.Enums;

namespace Login
{
    public class Login
    {
        //Bool for checking if the test login has succeded
        private static bool bTestSucceded = false;

        //Strings provided by the user
        private string? sName;
        private string? sPassword;

        //User info that has been encrypted with sym
        private Dictionary<string, string> SecuredInfo;
        private string loginString;

        //String of the symKey that has been encrypted with asym
        private string? sSecuredKey;

        //All the needed handlers for a login process
        private securityHandler m_SecurityHandler;
        private SqlHandler m_SqlHandler;
        private TrustedHandler m_TrustedHandler;

        public Login()
        {
            m_SqlHandler = new SqlHandler();
            m_SecurityHandler = new securityHandler();
            m_TrustedHandler = new TrustedHandler();
        }

        public bool LoginClientWithTrusted()
        {
            bool bReturnBool = m_TrustedHandler.CheckForTrusted();

            return bReturnBool;
        }

        public bool SetupTrusted(string name, string password, string mac, string uuid)
        {
            m_TrustedHandler.firstTimeSetup(name, password, mac, uuid);

            return false;
        }

        public bool LoginClient(string sInputName, string sInputPassword)
        {
            if (bTestSucceded != false)
            {
                sName = sInputName;
                sPassword = sInputPassword;

                try
                {
                    if (m_SqlHandler.checkForSafety(sInputName, sInputPassword))
                    {
                        SecuredInfo = m_SecurityHandler.getSecure(sInputName, sInputPassword);

                        return true;
                    }
                    else
                    {
                        throw new SafetyNowMatchedExceptions("The requirements for application safety are not reached");
                    }
                }
                catch (SafetyNowMatchedExceptions e)
                {
                    return false;
                }
                catch (Exception e) 
                { 
                    return false;
                }
                
            }
            else
            {
                Console.WriteLine("Could not connect to server!");
                return false;
            }
        }

        private void sendLogin()
        {
            try
            {
                networking.Networking.sendMessageToServer(loginString, "Login");
            }
            catch
            {
                Debug.WriteLine("Message could not be send, please check");
            }
        }

        /// <summary>
        /// Method for disposing all Objects and strings before the Login Process closes
        /// </summary>
        private void Dispose()
        {
            this.m_SecurityHandler = null;
            this.m_TrustedHandler = null;
            this.m_SqlHandler = null;

            this.sName = null;
            this.sPassword = null;
        }


        public static void Main()
        {
            if (TestProcess())
                bTestSucceded = true;
        }

        private static bool TestProcess()
        {
            bool bReturnBool = false;

            return bReturnBool;
        }
    }
}