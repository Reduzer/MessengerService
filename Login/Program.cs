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

        public unsafe bool LogInClient(string* name, string* password)
        {
            psName = name;
            psPassword = password;

            if (checkForTrused())
            {
                if (loginUser())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
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
                //WIP
                return false;
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