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
    public partial class drlPwrEx : genericForm
    {
        ProjectManager p;
        Form1 f;
        Holder holder;

        public drlPwrEx(ProjectManager _p, Form1 _f):this()
        {
            p = _p;
            f = _f;
        }

        public drlPwrEx()
        {
            InitializeComponent();

            InitializeHelper();

            if (ManagerDrlPwr.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerDrlPwr.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerDrlPwr.SaveInstanceControls, Controls);
            }
        }

        private void InitializeHelper()
        {

            buttnoVkl_drlPwr.UnHighlight();
            /*List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();

            Controls.Add(tumblerventilate_drlPwr);
            Controls.Add(tumblerprl_drlPwr);
            Controls.Add(tumblerprap1_drlPwr);
            Controls.Add(tumblerprap2_drlPwr);
            Controls.Add(tumblerantenna_drlPwr);
            Controls.Add(tumblerbsf1_drlPwr);
            Controls.Add(tumblerbsf2_drlPwr);
            Controls.Add(tumblerbrn1_drlPwr);
            Controls.Add(tumblerbrn2_drlPwr);
            Controls.Add(tumblerku_drlPwr);
            Controls.Add(tumblerbpr_drlPwr);
            Controls.Add(tumblerbop_drlPwr);
            Controls.Add(tumblerprmp1_drlPwr);
            Controls.Add(tumblerprmp2_drlPwr);
            Controls.Add(light1);

            holder.listOfFrom = this;
            holder.listOfControl = Controls;*/


        }

        private void tumblerventilate_drlPwr_Load(object sender, EventArgs e)
        {
            if (sender is Tumbler1)
            {
                var t = (Tumbler1)sender;
                if (t.Name == "tumblerprl_drlPwr")
                {
                    if (t.CurrentTumblerPosition() == Position.Up)
                    {
                        light1.SetLight(true);
                    }
                    else
                    {
                        light1.SetLight(false);
                    }
                }
            }
            ManagerDrlPwr.ClickToButton((Control)sender);
        }

        private void drlPwrEx_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerDrlPwr.ShowOffForm();
        }

        private void tumblerprl_drlPwr_Load(object sender, EventArgs e)
        {

        }
    }
}
