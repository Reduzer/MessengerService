using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Login;
using MessengerService.Exceptions;

namespace MessengerService.Objects
{
    internal class user
    {
        private unsafe string* pName;
        private unsafe string* pPassword;
        private string id;
     
        Dictionary<string, string> m_unserInfo = new Dictionary<string, string>();

        private Login.Login m_login;





        /// <summary>
        /// Default Constructor for a user
        /// </summary>
        /// <param name="name">Pointer to the Username in memory</param>
        /// <param name="password">Pointer to the Password in memory</param>
        public unsafe user(string* name, string* password)
        {
            this.pName = name;
            this.pPassword = password;
        }

        public bool login()
        {
            try
            {
                if (checkSql())
                {
                    if (getInfo())
                    {
                        return true;
                    }
                    else
                    {
                        throw new InfoLoadException();
                    }
                }
                else
                {
                    return false;
                }
            }
            catch(InfoLoadException)
            {
                MessageBox.Show("There has been an error while getting your information");

                return false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private bool checkSql()
        {


            return false;
        }

        private bool getInfo()
        {

        }

    }
}
