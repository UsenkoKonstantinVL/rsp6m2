using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Forms;
using rsp6m2.Manager;
using rsp6m2.Managers;
using indikator_rsp_6m2;


namespace rsp6m2
{
    public partial class Form1 : Form
    {


        public Form1(MainForm _m, ProjectManager _p) : this(_p)
        {

        }

        public Form1(ProjectManager _p):this()
        {

        }

        public Form1():base()
        {
            InitializeComponent();
            if(ManagerForm1.AllControlls == null)
            {
                List<Control> lc = new List<Control>();

                foreach(Control c in Controls)
                {
                    if(c is Button)
                    {
                        lc.Add(c);
                    }
                }

                foreach(Control c in panel1.Controls)
                {
                    if (c is Button)
                    {
                        lc.Add(c);
                    }
                }

                ManagerForm1.SetControls(null, lc);
            }
            else
            {
                List<Control> lc = ManagerForm1.AllControlls;
                foreach(Control c in Controls)
                {
                    foreach(Control  ac in lc)
                    {
                        if(c.Name == ac.Name)
                        {
                            //c = ac;
                        }
                    }
                }
            }
        }

        private void InitializeHelper()
        {



        }

        void InitializeForm()
        {
            /* drlStack1 = new drlStack();
             drlTop1 = new drlTop();
             prlTop1 = new prlTop(p, this);
             drlPwr1 = new drlPwr();
             prlPwr1 = new prlPwr(p, this);
             prlStack1 = new prlStack();*/
        }

        public Holder GetHolder()
        {
            return null;
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            ManagerForm1.ShowOffForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //drlStack drlStack1 = new drlStack(p, this);
            //drlStack1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //drlTop1 = new drlTop(p, this);
            //drlTop1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //prlTop1 = new prlTop(p, this);
            //prlTop1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //drlPwr1 = new drlPwr();
            ////drlPwr1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //prlPwr1 = new prlPwr(p, this);
            //prlPwr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //    prlStack1 = new prlStack(p, this);
            //    prlStack1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIKO_Click(object sender, EventArgs e)
        {
            ManagerForm1.ClickToButton((Control)sender);
            //indikator_rsp_6m2.Form1 f = new indikator_rsp_6m2.Form1();
            //f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //p.GetInfo(holder);

        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
          
        }
    }
}
