﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace RSI_Clicker
{
    class AutoClicker
    {
        bool clicked = false; //click only once when mouse has stopped
        private const int TimeStopBeforeClick = 100; 
        Point oldMousePos = new Point(0, 0); 

        Timer clickTimer = new Timer() { Enabled = true, Interval = TimeStopBeforeClick };        
        User32Wrapper MouseFunction = new User32Wrapper();

        public AutoClicker()
        {
            this.clickTimer.Tick += OnClickTimerTick; 
        }

        public void TurnOffClickTimer()
        {
            clickTimer.Stop();
        }

        public void TurnOnClickTimer()
        {
            clickTimer.Start();
        }

        public void OnClickTimerTick(object source, EventArgs e)
        {
            CheckIfCursorMoved();
        }


//Checks if the previous position is different than current position every 100ms
        public void CheckIfCursorMoved()
        {
            
            if (oldMousePos == System.Windows.Forms.Cursor.Position) {
                if (!clicked)
                {
                    MouseFunction.DoLeftMouseClick();
                    clicked = true;
                }
            }

            else {
                oldMousePos = System.Windows.Forms.Cursor.Position;
                clicked = false;
            }
            
        }

    }
}
