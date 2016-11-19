using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iko_Disp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ikoDisp Disp = new ikoDisp();
            TargManager.refr(radioButton1.Checked);
            Disp.Show();
            Disp.Left = 0;
            Disp.Top = 0;
          
        }
    }
}
