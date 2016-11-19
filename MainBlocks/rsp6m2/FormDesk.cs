using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Forms;

namespace rsp6m2
{
    public partial class FormDesk : DeskForm
    {
        public FormDesk()
        {
            InitializeComponent();
        }

 
        /*drlTop drlTop1 = new drlTop();
        prlTop prlTop1 = new prlTop();
        drlPwr drlPwr1 = new drlPwr();
        prlPwr prlPwr1 = new prlPwr();*/
        //prlStack prlStack1 = new prlStack();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*drlStack drlStack1 = new drlStack(p, this);
            drlStack1.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //drlTop1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // prlTop1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // drlPwr1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // prlPwr1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //prlStack1.Show();
        }
    }
}
