using System;
using System.Reflection.Metadata;
using Login.Exceptions;
using Login.Security;
using Login.SQL;
using Login.TrustedDevice;
using Login.Safety;



namespace Login
{
    public class Login
    {
        private static bool bTestSucceded = false;

        //Strings provided by the user
        private string? sName;
        private string? sPassword;

        private string? sNameSecure;
        private string? sPasswordSecure;

        private string? sSecuredKey;

        //All the needed handlers for a login process
        private securityHandler m_SecurityHandler;
        private SqlHandler m_SqlHandler;
        private TrustedHandler m_TrustedHandler;
        private SafetyHandler m_SafetyHandler;

        public Login()
        {
            m_SqlHandler = new SqlHandler();
            m_SecurityHandler = new securityHandler();
            m_TrustedHandler = new TrustedHandler();
            m_SafetyHandler = new SafetyHandler();
        }

        public bool LoginClient(string sInputName, string sInputPassword)
        {
            if (bTestSucceded != false)
            {
                sName = sInputName;
                sPassword = sInputPassword;

                try
                {
                    if (true)
                    {
                        sNameSecure = m_SecurityHandler.getSecure(sInputName);
                        sPasswordSecure = m_SecurityHandler.getSecure(sPassword);
                        sSecuredKey = m_SecurityHandler.getKey();

                        Dispose();

                        return true;
                    }
                    else
                    {
                        throw new SafetyNowMatchedExceptions("Exception thrown with the provided information, please check input");
                    }
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method for disposing all Objects and strings before the Login Process closes
        /// </summary>
        private void Dispose()
        {
            this.m_SafetyHandler = null;
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
            return false;
        }
    }
}