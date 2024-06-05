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
<<<<<<< HEAD
=======

        }

        public unsafe UserObject LogInClient(string* name, string* password)
        {
            UserObject returnUser;

>>>>>>> 6f86a6dc8e5e3d284e469a4d280206ee882d32dd
            if (checkForTrused())
            {
                loginUser();
                returnUser = m_User;
                return returnUser;
            }
<<<<<<< HEAD
        }


        public unsafe void LogInClient(string* name, string* password)
        {
=======

>>>>>>> 6f86a6dc8e5e3d284e469a4d280206ee882d32dd
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
                //WIP
                return false;
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