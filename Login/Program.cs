using System;

using Login.Exceptions;
using Login.Objects;
using Login.Security;
using Login.SQL;
using Login.src;

namespace Login
{
    public class Login
    {
        private string sName;
        private string sPassword;

        private  SqlHandler m_sqlHandler;
        private  trustedDevice m_trusted;

        public Login()
        {
            m_sqlHandler = new SqlHandler();
            m_trusted = new trustedDevice();
        }

        public bool LogInClient(string name, string password)
        {
            sName = name;
            sPassword = password;

            // !checkForTrused()
            if (true)
            {
                return loginUser();

            }
            else
            {
                return false;
            }
        }

        private bool loginUser()
        {
            return m_sqlHandler.Sql(sName, sPassword);  
        }

        private bool checkForTrused()
        {
            /*
             * 
             * Wie Umsetzbar?
             * Lokale speicherung von Daten?
             * Wenn ja, wie?
            */
            m_trusted.isDeviceKnown();



            return false;
        }

        public static void Main()
        {
            
        }
    }
}