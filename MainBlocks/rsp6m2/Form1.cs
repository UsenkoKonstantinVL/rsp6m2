using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Forms;
using rsp6m2.Manager;
using indikator_rsp_6m2;

namespace rsp6m2
{
    public partial class Form1 : genericForm
    {
        private ProjectManager p;
        MainForm m;
        Holder holder;

        #region Form
        drlStack drlStack1;
        drlTop drlTop1;
        prlTop prlTop1;
        drlPwr drlPwr1;
        prlPwr prlPwr1;
        prlStack prlStack1;
        #endregion

        public Form1(MainForm _m, ProjectManager _p) : this(_p)
        {
            m = _m;
            InitializeForm();
        }

        public Form1(ProjectManager _p):this()
        {
            p = _p;
        }

        public Form1()
        {
            this.Enabled = false;
            InitializeComponent();
            InitializeHelper();

            this.Enabled = true;
        }

        private void InitializeHelper()
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();
            Controls.Add(buttonDRL);
            Controls.Add(buttonIKO);
            Controls.Add(buttonPRL);
            Controls.Add(button6);//drlpwr
            Controls.Add(button4);//drltop
            Controls.Add(button5);//prltop
            Controls.Add(button7);//prlpwr
            holder.listOfFrom = this;
            holder.listOfControl = Controls;


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
            return holder;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.DeleteInfo();
            m.Enabled = true;
            if (prlTop1 != null)
                prlTop1.Close();
            if (prlPwr1 != null)
                prlPwr1.Close();
            if (prlStack1 != null)
                prlStack1.Close();
            if (drlStack1 != null)
                drlStack1.Close();
            if (drlTop1 != null)
                drlTop1.Close();
            if (drlPwr1 != null)
                drlPwr1.Close();

            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drlStack drlStack1 = new drlStack(p, this);
            drlStack1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drlTop1 = new drlTop(p, this);
            drlTop1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prlTop1 = new prlTop(p, this);
            prlTop1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drlPwr1 = new drlPwr();
            //drlPwr1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prlPwr1 = new prlPwr(p, this);
            prlPwr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prlStack1 = new prlStack(p, this);
            prlStack1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIKO_Click(object sender, EventArgs e)
        {
            indikator_rsp_6m2.Form1 f = new indikator_rsp_6m2.Form1();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p.GetInfo(holder);

        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if(this.Enabled == true)
            {
                if (p != null)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "System.Windows.Forms.Button")
                        {
                            ((Button)c).FlatAppearance.BorderSize = 0;
                        }
                    }
                    foreach (Control c in panel1.Controls)
                    {
                        if (c.GetType().ToString() == "System.Windows.Forms.Button")
                        {
                            ((Button)c).FlatAppearance.BorderSize = 0;
                        }
                    }
                    p.GetInfo(holder);

                    
                   
                }
            }
        }
    }
}
