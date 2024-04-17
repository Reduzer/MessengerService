using Messenges.Enums;
using Messenges.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenges.Factory
{
    internal class createMessage
    {
        private List<string> types = new List<string>();
        private Dictionary<string, object> messageObjects = new Dictionary<string, object>();

        public createMessage() 
        {
            
        }

        private void init()
        {
            types.Clear();

            string var;

            //get types from enums
            //Fill list
            
            //check if list length is equal to enum length

        }

        private void fillList()
        {

        }

        private void fillDictionary()
        {

        }

        /// <summary>
        /// Diese Methode erstellt eine neue Nachricht, des Typens, welche vom nutzer angegeben wird
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Message Object</returns>
        public object createMSG(string type)
        {
            object m_returnObject;
            try
            {
                if (checkType(type))
                {
                    m_returnObject = createMessage(type);
                    return m_returnObject;
                }
                else
                {
                    throw new UnknownTypeException();
                }
            }
            catch (UnknownTypeException)
            {
                return null;
            }

        }

        private bool checkType(string type)
        {
            if (types.Contains(type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private object createMessage(string type)
        {
            object m_returnObject;
            m_returnObject = new object();

        }

    }
}
