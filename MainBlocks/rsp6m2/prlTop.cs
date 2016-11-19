using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Manager;
namespace rsp6m2
{
    public partial class prlTop : genericForm
    {
        ProjectManager p;
        Form1 f;
        public Holder holder;

        public prlTop(ProjectManager _p, Form1 _f):this()
        {
            p = _p;
            f = _f;
        }

        public prlTop()
        {
            InitializeComponent();
            InitializeHelper();
        }

        private void InitializeHelper()
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();
            //Controls.Add(tumbler11);
            //Controls.Add(roundTrumbler1);
            holder.listOfFrom = this;
            holder.listOfControl = Controls;


        }

        private void prlTop_Load(object sender, EventArgs e)
        {
            f.Enabled = false;
            p.GetInfo(holder);
        }

        private void prlTop_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled = true;
            p.DeleteInfo();
        }
    }
}
