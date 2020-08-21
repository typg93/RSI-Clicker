using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSI_Clicker
{
    class User32Wrapper
    {
        //uses mouse_event function in user32.dll to actuate mouse click functions
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public const int MouseEventLeftClickDown = 0x0002;
        public const int MouseEventLeftClickUp = 0x0004;
        public const int MouseEventRightClickDown = 0x0008;
        public const int MouseEventRightClickUp = 0x0010;
        public const int MouseEventClickSpeed = 10; //in milliseconds

        public void DoLeftMouseClick()
        {
            mouse_event(MouseEventLeftClickDown, 0, 0, 0, 0);
            Thread.Sleep(MouseEventClickSpeed);
            mouse_event(MouseEventLeftClickUp, 0, 0, 0, 0);
        }
    }
}
