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

        private static SqlHandler m_sqlHandler;
        private static trustedDevice m_trusted;

        public Login()
        {
            m_sqlHandler = new SqlHandler();
            m_trusted = new trustedDevice();
        }

        public unsafe void LogInClient(string* name, string* password)
        {
            this.psName = name;
            this.psPassword = password;

            loginUser();
        }

        private unsafe void loginUser()
        {
            m_sqlHandler.Sql(psName, psPassword);
        }

        private static bool checkForTrused()
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
            if (checkForTrused())
            {

            }
        }
    }
}