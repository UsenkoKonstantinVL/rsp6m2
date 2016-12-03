using indikator_rsp_6m2;
using rsp6m2.Controls;
using rsp6m2.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2
{
    public partial class drlPwr : genericForm
    {
        public drlPwr()
        {
            InitializeComponent();

            if (ManagerDrlPwr.AllControlls == null)
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
                    else if (c is Controls.Voltmetr)
                    {
                        lc.Add(c);
                        ilc.Add(c);
                    }
                }

                ManagerDrlPwr.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerDrlPwr.SaveInstanceControls, Controls);
            }
        }

        private void drlPwr_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerDrlPwr.ShowOffForm();
        }
    }
}
