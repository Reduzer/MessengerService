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
        private deleteMessage m_deleteMessage;

        public Messenges() 
        { 
            m_createMessage = new createMessage();
            m_deleteMessage = new deleteMessage();
        }

        public static void Main()
        {

        }

        public void newMessage(string type)
        {
            object messageObject = m_createMessage.createMSG(type);
        }

        public void deleteMessage(object selectedMessage)
        {
            m_deleteMessage.delete(selectedMessage);
        }
    }
}