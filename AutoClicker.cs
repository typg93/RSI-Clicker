using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_Clicker
{
    class AutoClicker
    {
        int mouseX = 0;
        int mouseY = 0;

        public void CheckIfCursorMoved(int oldX, int oldY)
        {
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            if (oldX == mouseX && oldY == mouseY){
                //do mouse click
            }
        }

    }
}
