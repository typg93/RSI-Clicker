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
        bool clicked = false; //click only once when mouse has stopped
        Point oldMousePos = new Point(0, 0);

        Timer clickTimer = new Timer() { Enabled = true, Interval = 100 };        
        User32Wrapper Mouse = new User32Wrapper();

        public AutoClicker()
        {
            this.clickTimer.Tick += OnClickTimerTick; 
        }

       
        public void OnClickTimerTick(object source, EventArgs e)
        {
            CheckIfCursorMoved();
        }

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
