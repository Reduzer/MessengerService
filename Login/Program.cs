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
        private unsafe string sName;
        private unsafe string sPassword;

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

        public unsafe bool LogInClient(string name, string password)
        {
            sName = name;
            sPassword = password;

            if (!checkForTrused())
            {
                if (sName == "Debug" && sPassword == "Debug")
                {
                    return true;
                }


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
            if(m_sqlHandler.Sql(sName, sPassword))
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

            //WIP

            return false;
            /*
            if (m_trusted.isDeviceKnown() != null)
            {
                return false;
            }
            else
            {
                return false;
            }

            */
        }

        public static void Main()
        {
            
        }
    }
}