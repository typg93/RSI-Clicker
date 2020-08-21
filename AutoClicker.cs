using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_Clicker
{
    class AutoClicker
    {
        Point oldMousePos = new Point(0, 0);
        bool clicked = false;

        User32Wrapper Mouse = new User32Wrapper();

        public void CheckIfCursorMoved()
        {
            if (oldMousePos == Cursor.Position) {
                if (!clicked)
                {
                    Mouse.DoLeftMouseClick();
                    clicked = true;
                }
            }

            else {
                oldMousePos = Cursor.Position;
                clicked = false;
            }
            
        }

    }
}
