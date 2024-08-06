using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Input;

namespace Login.Security.Hashing
{
    internal class generateSalt
    {
        private string _sMouseCoordinates;
        private string _sDateTime;

        public salt getSalt()
        {
            salt returnSalt;

            _sDateTime = System.DateTime.Now.ToString();

            returnSalt = new salt(_sDateTime, _sMouseCoordinates);

            return returnSalt;
        }

        public void setMousePosition(Point position)
        {
            string convertString = position.ToString();
        }
    }
}
