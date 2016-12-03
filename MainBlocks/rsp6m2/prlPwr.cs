using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.HelpClass;
using rsp6m2.Manager;
using rsp6m2.Managers;

namespace rsp6m2
{
    public partial class prlPwr : genericForm
    {
        ProjectManager p;
        Form1 f;
        Holder holder;

        public prlPwr(ProjectManager _p, Form1 _f):this()
        {
            p = _p;
            f = _f;
        }

        public prlPwr()
        {
            InitializeComponent();
            InitializeHelper();

            Position pos = Position.Down;
            (tumblerventilate_prlpwr).SetTumblerPosition(pos);
             (tumblerprl_prlpwr).SetTumblerPosition(pos);
             (tumblerprap1_prlpwr).SetTumblerPosition(pos);
             (tumblerprap2_prlpwr).SetTumblerPosition(pos);
             (tumblerantenna_prlpwr).SetTumblerPosition(pos);
             (tumblerbsf1_prlpwr).SetTumblerPosition(pos);
             (tumblerbsf2_prlpwr).SetTumblerPosition(pos);
             (tumblerbrn1_prlpwr).SetTumblerPosition(pos);
             (tumblerbrn2_prlpwr).SetTumblerPosition(pos);
             (tumblerku_prlpwr).SetTumblerPosition(pos);
             (tumblerbpr_prlpwr).SetTumblerPosition(pos);
             (tumblerbop_prlpwr).SetTumblerPosition(pos);
             (tumblerprmp1_prlpwr).SetTumblerPosition(pos);
             (tumblerprmp2_prlpwr).SetTumblerPosition(pos);


            if (ManagerPrlPwr.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        lc.Add(c);
                    }
                    else if (c is Tumbler)
                    {
                        lc.Add(c);
                        ilc.Add(c);
                    }
                    else if (c is RoundTrumbler)
                    {
                        lc.Add(c);
                        ilc.Add(c);
                    }
                    else if (c is Light)
                    {
                        lc.Add(c);
                        ilc.Add(c);
                    }
                    else if (c is Voltmetr)
                    {
                        lc.Add(c);
                        ilc.Add(c);
                    }
                }

                ManagerPrlPwr.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerPrlPwr.SaveInstanceControls, Controls);
            }

        }


        private void InitializeHelper()
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();

            Controls.Add(tumblerventilate_prlpwr);
            Controls.Add(tumblerprl_prlpwr);
            Controls.Add(tumblerprap1_prlpwr);
            Controls.Add(tumblerprap2_prlpwr);
            Controls.Add(tumblerantenna_prlpwr);
            Controls.Add(tumblerbsf1_prlpwr);
            Controls.Add(tumblerbsf2_prlpwr);
            Controls.Add(tumblerbrn1_prlpwr);
            Controls.Add(tumblerbrn2_prlpwr);
            Controls.Add(tumblerku_prlpwr);
            Controls.Add(tumblerbpr_prlpwr);
            Controls.Add(tumblerbop_prlpwr);
            Controls.Add(tumblerprmp1_prlpwr);
            Controls.Add(tumblerprmp2_prlpwr);
            Controls.Add(light1);

            holder.listOfFrom = this;
            holder.listOfControl = Controls;


        }



        private void tumbler11_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void prlPwr_Load(object sender, EventArgs e)
        {
           /* f.Enabled = false;
            p.GetInfo(holder);*/
        }

        private void prlPwr_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* f.Enabled = true;
             p.DeleteInfo();*/
            ManagerPrlPwr.ShowOffForm();
        }

        private void tumbler11_Load(object sender, EventArgs e)
        {

        }

        private void tumbler11_Click(object sender, EventArgs e)
        {
            /*/ p.CheckClick(tumblerventilate_prlpwr);
             p.GetInfo();//----vtyzk nen*/
            ManagerPrlPwr.ClickToButton((Control)sender);
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void tumblerventilate_prlpwr_Click(object sender, EventArgs e)
        {
            /* p.CheckClick((Control)sender);
             p.GetInfo();
             if(((Control)sender).Name == "tumblerprl_prlpwr")
             {
                 if (((Tumbler)sender).CurrentTumblerPosition() == Position.Up)
                 {
                     light1.LightOn();
                 }
                 else
                 {
                     light1.LightOff();
                 }
             }*/
            ManagerPrlPwr.ClickToButton((Control)sender);
        }

        private void tumblerprl_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerprap1_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerprap2_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerantenna_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerbsf1_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerbsf2_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerbrn1_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerbrn2_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerku_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerprmp2_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerprmp1_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerbop_prlpwr_Load(object sender, EventArgs e)
        {

        }

        private void tumblerbpr_prlpwr_Load(object sender, EventArgs e)
        {

        }
    }
}
