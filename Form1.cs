using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_Clicker
{
    public partial class RSIClick : Form
    {
        readonly AutoClicker autoClick = new AutoClicker();
        readonly GlobalHotKey ghk;
        int test = 0;
        bool autoClickOn = false;

        public RSIClick()
        {
            InitializeComponent();
            ghk = new GlobalHotKey(this, 0x0000, Keys.F10);
            ghk.Register();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            test++;
            ClicksLabel.Text += test;  
        }

        #region AutoClick HotKey Activate
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == GlobalHotKey.Constants.WM_HOTKEY_MSG_ID)
            {
                AutoClickSwitch();
            }
            base.WndProc(ref m);
        }
#endregion
        #region AutoClick Switch Button
        private void AutoClickButton_Click(object sender, EventArgs e)
        {
            AutoClickSwitch();
        }

        private void AutoClickSwitch()
        {
            //turn OFF autoclicking
            if (autoClickOn)
            {
                autoClickOn = false;
                autoClick.TurnOffClickTimer();
                AutoClickButton.Text = "turn ON auto clicker";
            }
            //turn ON autoclicking
            else
            {
                autoClickOn = true;
                autoClick.TurnOnClickTimer();
                AutoClickButton.Text = "turn OFF auto clicker";
            }
        }
        #endregion

    }
}
