using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenges.Factory
{
    internal class deleteMessage
    {
        private object m_messageObject;

        public deleteMessage() 
        {
        
        }

        public void delete(object messageOBject)
        {
            m_messageObject = messageOBject;
        }
    }
}
