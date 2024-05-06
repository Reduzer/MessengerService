using System;

using Login.Exceptions;
using Login.Security;
using Login.SQL;

namespace Login
{
    public class Login
    {
        private unsafe string* psName;
        private unsafe string* psPassword;

        private SqlHandler m_sqlHandler;

        public Login()
        {
            m_sqlHandler = new SqlHandler();
        }
        
        public static void Main()
        {

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
    }
}