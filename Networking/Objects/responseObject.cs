using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.Objects
{
    public class responseObject
    {
        string sMessage;
        string sType;
        int nUID;

        /// <summary>
        /// Default constructor for a responseObject
        /// </summary>
        /// <param name="message">Message recieved from the server</param>
        /// <param name="type">Type recieved from the server</param>
        public responseObject(string message, string type) 
        {
            this.sMessage = message;
            this.sType = type;
            this.nUID = 0;
        }

        /// <summary>
        /// Constructor for a responseObject with an additional unique id
        /// </summary>
        /// <param name="message">Message recieved from the server</param>
        /// <param name="type">Type recieved from the server</param>
        /// <param name="uid">A unique id for recognising messages</param>
        public responseObject(string message, string type, int uid) 
        {
            this.sMessage = message;
            this.sType = type;
            this.nUID = uid;
        }

        #region Get

        public string Message
        {
            get { return sMessage; }
        }

        public string Type
        {
            get{return sType;}
        }

        public int UID 
        {  
            get{return nUID;}
        }

        #endregion
    }
}
