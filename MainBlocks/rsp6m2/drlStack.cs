using System;
using System.Collections.Generic;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.HelpClass;
using rsp6m2.Manager;
using rsp6m2.Managers;

namespace rsp6m2
{
    public partial class drlStack : genericForm
    {
        ProjectManager p;
        Form f;
        Holder holder;

        public drlStack(ProjectManager _p, Form _f)
        {
            InitializeComponent();
            p = _p;
            f = _f;
            InitializeHelper();

            //button15
        }

        public drlStack()
        {
            InitializeComponent();

            //if (ManagerDrlStack.AllControlls == null)
            {
                List<Control> lc = new List<Control>();

                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        lc.Add(c);
                    }
                }

                ManagerDrlStack.SetControls(lc);
            }
            /*else
            {
                List<Control> lc = ManagerDrlStack.AllControlls;
                foreach (Control c in Controls)
                {
                    foreach (Control ac in lc)
                    {
                        if (c.Name == ac.Name)
                        {
                            //c = ac;
                        }
                    }
                }
            }*/
        }

        private void InitializeHelper()
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();
            Controls.Add(button15_drl);
            /*Controls.Add(buttonIKO);
            Controls.Add(buttonPRL);
            Controls.Add(button6);//drlpwr
            Controls.Add(button4);//drltop
            Controls.Add(button5);//prlpwr
            Controls.Add(button7);//prltop*/
            holder.listOfFrom = this;
            holder.listOfControl = Controls;


        }

        br009 br0091 = new br009();
        //bp213 bp2131 = new bp213();
        bp135 bp1351 = new bp135();
        brn01 brn011 = new brn01();
        //bost bost1 = new bost();
        buv011 buv0111 = new buv011();
        bchv021 bchv0211 = new bchv021();
        bchk011 bchk0111 = new bchk011();
        bu011 bu0111 = new bu011();
        bki011 bki0111 = new bki011();
        //bp142 bp1421 = new bp142();
        //bp138 bp1381 = new bp138();
        //bp127 bp1271 = new bp127();
        bksg bksg1 = new bksg();
        //bpr011sm1 bpr011sm11 = new bpr011sm1();
        bpchs bpchs1 = new bpchs();
        //bpr011sm2 bpr011sm21 = new bpr011sm2();
        sp02 sp021 = new sp02();
        bpm011 bpm0111 = new bpm011();
        bvm011 bvm0111 = new bvm011();
        pvk pvk1 = new pvk();
        

        private void button1_Click(object sender, EventArgs e)
        {
            br0091.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Button);
            //bp2131.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            br0091.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Button);
            //bp2131.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bp1351.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            brn011.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Button);
            //bost1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Button);
            //bost1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buv0111.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buv0111.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bchv0211.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bchk0111.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            ManagerDrlStack.ClickToButton((Control)sender);
            //bu0111.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bki0111.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*bp142 bp1421 = new bp142(p, this);
            bp1421.Show();*/
            ManagerDrlStack.ClickToButton((Control)sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton((Control)sender);
            //bp1381.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Control);
            //bp1271.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bksg1.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Control);
            //bpr011sm11.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Control);
            //bpchs1.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bpchs1.Show();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            ManagerDrlStack.ClickToButton(sender as Control);
            //bpr011sm21.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sp021.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bpm0111.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            bpm0111.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            bvm0111.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            bvm0111.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sp021.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pvk1.Show();
        }

        private void drlStack_Load(object sender, EventArgs e)
        {
            /*p.CheckClick((Control)sender);
            p.GetInfo(holder);
            f.Enabled = false;*/
        }

        private void drlStack_EnabledChanged(object sender, EventArgs e)
        {
            /*if (this.Enabled == true)
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
                    p.GetInfo(holder);
                }
            }*/
        }

        private void drlStack_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*f.Enabled = true;
            p.DeleteInfo();*/
            ManagerDrlStack.ShowOffForm();

        }
    }
}
