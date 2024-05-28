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
        private unsafe string* psName;
        private unsafe string* psPassword;

        private  SqlHandler m_sqlHandler;
        private  trustedDevice m_trusted;

        private UserObject m_User;

        public Login()
        {
            m_sqlHandler = new SqlHandler();
            m_trusted = new trustedDevice();
        }

        public void LogInClient()
        {

        }

        public unsafe UserObject LogInClient(string* name, string* password)
        {
            UserObject returnUser;

            if (checkForTrused())
            {
                loginUser();
                returnUser = m_User;
                return returnUser;
            }

            psName = name;
            psPassword = password;

            if (loginUser())
            {
                returnUser = m_User;
                return returnUser;
            }
            else
            {
                return null;
            }
        }

        private unsafe bool loginUser()
        {
            if(m_sqlHandler.Sql(psName, psPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
                
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

        private unsafe void fillUserInfo(string* name, int* id)
        {

        }

        public static void Main()
        {
            
        }
    }
}