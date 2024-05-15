using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Login.Exceptions;

namespace Login.SQL
{
    internal class checkIfSafe
    {
        private unsafe string* psUserName;
        private unsafe string* psUserPassword;


        public unsafe bool isSafe(string* name, string* password)
        {
            this.psUserName = name;
            this.psUserPassword = password;

            try
            { 
                if (check())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private unsafe bool check()
        {
            try
            {
                if (checkNm() && checkPW())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }

        private unsafe bool checkNm()
        {
            string  sUserInput = *psUserName;

            if (sUserInput.Length > 100)
            {
                throw new StringLengthException();
            }
            else
            {
                if (sUserInput.Contains("DROP") || sUserInput.Contains("DELETE") || sUserInput.Contains("INSERT") || sUserInput.Contains("UPDATE") || sUserInput.Contains('"'))
                {
                    throw new IllegalSqlCommandException();
                }
                else
                {
                    return true;
                }
            }
        }

        private unsafe bool checkPW()
        {
            string sUserInput = *psUserPassword;

            if (sUserInput.Length > 100)
            {
                throw new StringLengthException();
            }
            else
            {
                if (sUserInput.Contains("DROP") || sUserInput.Contains("DELETE") || sUserInput.Contains("INSERT") || sUserInput.Contains("UPDATE") || sUserInput.Contains('"'))
                {
                    throw new IllegalSqlCommandException();
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
