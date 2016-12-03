using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Forms;
using rsp6m2.Controls;
using rsp6m2.HelpClass;
using rsp6m2.Manager;
using rsp6m2.Managers;

namespace rsp6m2
{
    public partial class bp142 : genericForm
    {
        ProjectManager p;
        Form f;
        Holder holder;


        public bp142(ProjectManager _p, Form _f)
        {
            InitializeComponent();
            InitializeHelper();
            p = _p;
            f = _f;
            tumblerPowerPrl.SetTumblerPosition(Position.Down);
            tumblerPowerDrl.SetTumblerPosition(Position.Down);


            if (ManagerDrlStack.AllControlls == null)
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
            else
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
            }
        }


        public bp142()
        {
            InitializeComponent();
            InitializeHelper();
            tumblerPowerPrl.SetTumblerPosition(Position.Down);
            tumblerPowerDrl.SetTumblerPosition(Position.Down);


            if (Managerbp142.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        lc.Add(c);
                    }
                    else if(c is Tumbler)
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

                Managerbp142.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(Managerbp142.SaveInstanceControls, Controls);
            }
        }


        private void InitializeHelper()
        {

        }

        private void bp142_Load(object sender, EventArgs e)
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();

            Controls.Add(tumblerPowerPrl);
            Controls.Add(tumblerPowerDrl);

            holder.listOfFrom = this;
            holder.listOfControl = Controls;

           // f.Enabled = false;
           // p.GetInfo(holder);
        }

        private void tumblerPowerPrl_Load(object sender, EventArgs e)
        {

        }

        private void tumblerPowerPrl_Click(object sender, EventArgs e)
        {
            /*p.CheckClick((Control)sender);
            p.GetInfo();*/
            Managerbp142.ClickToButton((Control) sender);
        }

        private void tumblerPowerDrl_Click(object sender, EventArgs e)
        {
            //p.CheckClick((Control)sender);
            //p.GetInfo();
            Managerbp142.ClickToButton((Control)sender);
        }

        private void bp142_FormClosing(object sender, FormClosingEventArgs e)
        {
            //f.Enabled = true;
            //p.DeleteInfo();
            Managerbp142.ShowOffForm();
        }

        private void tumblerPowerDrl_Load(object sender, EventArgs e)
        {

        }
    }
}
