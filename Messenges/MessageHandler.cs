using Messenges.Factory;
using System;

namespace Messenges
{
    /// <summary>
    /// Klasse für das Verwalten von Messenges
    /// </summary>
    public class Messenges
    {
        private createMessage m_createMessage;

        public Messenges() 
        { 
            m_createMessage = new createMessage();
        }

        public static void Main()
        {

        }

        public void newMessage(string type)
        {
            object messageObject = m_createMessage.createMSG(type);
        }

        public void deleteMessage()
        {
            
        }
    }
}