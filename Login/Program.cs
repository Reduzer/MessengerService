using System;

using Login.Exceptions;
using Login.Security;
using Login.SQL;
using Login.src;

namespace Login
{
    public class Login
    {
        private unsafe string* psName;
        private unsafe string* psPassword;

        private  SqlHandler m_sqlHandler;
        private  trustedDevice m_trusted;

        public Login()
        {
            m_sqlHandler = new SqlHandler();
            m_trusted = new trustedDevice();
        }

        public void LogInClient()
        {

        }

        public unsafe void LogInClient(string* name, string* password)
        {
            if (checkForTrused())
            {
                loginUser();
            }
            psName = name;
            psPassword = password;

            loginUser();
        }

        private unsafe void loginUser()
        {
            m_sqlHandler.Sql(psName, psPassword);
        }

        private bool checkForTrused()
        {
            if (m_trusted.isDeviceKnown() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main()
        {
            
        }
    }
}