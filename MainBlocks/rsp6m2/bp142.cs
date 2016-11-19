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

            f.Enabled = false;
            p.GetInfo(holder);
        }

        private void tumblerPowerPrl_Load(object sender, EventArgs e)
        {

        }

        private void tumblerPowerPrl_Click(object sender, EventArgs e)
        {
            p.CheckClick((Control)sender);
            p.GetInfo();
        }

        private void tumblerPowerDrl_Click(object sender, EventArgs e)
        {
            p.CheckClick((Control)sender);
            p.GetInfo();
        }

        private void bp142_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled = true;
            p.DeleteInfo();
        }

        private void tumblerPowerDrl_Load(object sender, EventArgs e)
        {

        }
    }
}
