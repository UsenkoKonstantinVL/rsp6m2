using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class tumbler3 : UserControl
    {
        int cond = 0;
        int pl = 1;
        public tumbler3()
        {
            InitializeComponent();
            cond = 1;
            pl = 1;
        }

        public int Position  { get {return cond; } set {cond = value; } }

        private void tumbler3_MouseClick(object sender, MouseEventArgs e)
        {
            cond += pl;

            if(cond < 0)
            {
                cond = 0;
                pl = 1;
            }

            if(cond > 2)
            {
                cond = 2;
                pl = 1;
            }

            if(cond == 0)
            {
                BackgroundImage = Properties.Resources.Tumbler2On;
            }
            else if(cond == 1)
            {
                BackgroundImage = Properties.Resources.iron_middle;
            }
            else
            {
                BackgroundImage = Properties.Resources.Tumbler2Off;
            }
        }


    }
}
