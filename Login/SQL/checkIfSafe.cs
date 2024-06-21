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
        public unsafe bool isSafe(string* name, string* password)
        {
            try
            { 
                if (checkInput(name, password))
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

        private unsafe bool checkInput(string* name, string* password)
        {
            string sUserInput = *name;
            string sUserPassword = *password;

            if (sUserInput.Length > 180)
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
    }
}
