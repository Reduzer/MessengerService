using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MessengerService.Util
{
    public static class GetMousePosition
    {
        public static Point getMousePosition()
        {
            Point point = System.Windows.Forms.Control.MousePosition;

            return point;
        }
    }
}
