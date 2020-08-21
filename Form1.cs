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
        
        User32Wrapper Mouse = new User32Wrapper();
        int test = 0;
        
        public RSIClick()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

         
        private void Button_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            test++;
            ClicksLabel.Text += test;
            Mouse.DoLeftMouseClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
