using System;

using Login.Exceptions;
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

        public Login()
        {
            m_sqlHandler = new SqlHandler();
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

        public static void Main()
        {
            
        }
    }
}