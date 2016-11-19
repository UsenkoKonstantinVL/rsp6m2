using System;
using System.Windows.Forms;

namespace iko_Disp
{
    public partial class ikoDisp : Form
    {
        public ikoDisp()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ikoPasControl1.start(); 
            this.Controls.Add(TargManager.Targ1.shortLabl);
            this.Controls.Add(TargManager.Targ1.Labl);
            TargManager.Targ1.shortLabl.BringToFront();
            TargManager.Targ1.Labl.BringToFront();

            this.Controls.Add(TargManager.Targ2.shortLabl);
            this.Controls.Add(TargManager.Targ2.Labl);
            TargManager.Targ2.shortLabl.BringToFront();
            TargManager.Targ2.Labl.BringToFront();

            this.Controls.Add(TargManager.Targ3.shortLabl);
            this.Controls.Add(TargManager.Targ3.Labl);
            TargManager.Targ3.shortLabl.BringToFront();
            TargManager.Targ3.Labl.BringToFront();

          /*  this.Controls.Add(TargManager.Targ4.shortLabl);
            this.Controls.Add(TargManager.Targ4.Labl);
            TargManager.Targ4.shortLabl.BringToFront();
            TargManager.Targ4.Labl.BringToFront();

            this.Controls.Add(TargManager.Targ5.shortLabl);
            this.Controls.Add(TargManager.Targ5.Labl);
            TargManager.Targ5.shortLabl.BringToFront();
            TargManager.Targ5.Labl.BringToFront();

            this.Controls.Add(TargManager.Targ6.shortLabl);
            this.Controls.Add(TargManager.Targ6.Labl);
            TargManager.Targ6.shortLabl.BringToFront();
            TargManager.Targ6.Labl.BringToFront();*/
            ikO_control1.start();
           // ikoPasControl1.start();
        }

        private void ikoDisp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ikO_control1.Zoom = trackBar1.Value;
        }
    }
}
