using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RSI_Clicker
{
    public class GlobalHotKey
    {
        private int modifier;
        private int key;
        private IntPtr hWnd;
        private int id;

        public struct Constants {
            public const int NoMod = 0x0000;
            public const int Alt = 0x0001;
            public const int Shift = 0x0004;
            public const int Win = 0x0008;

            //windows message id for hotkey
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }

        public GlobalHotKey(Form form)
        {
            this.hWnd = form.Handle;
        }
        public GlobalHotKey(Form form, int modifier, Keys key)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            this.modifier = modifier;
            id = this.GetHashCode();
        }

        public bool Register()
        {
            return RegisterHotKey(hWnd, id, modifier, key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(hWnd, id);
        }

        public override int GetHashCode()
        {
            return modifier ^ key ^ hWnd.ToInt32();
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}
