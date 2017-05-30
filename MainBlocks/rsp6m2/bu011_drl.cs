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
    public partial class bu011_drl : genericForm
    {
        public bu011_drl()
        {
            InitializeComponent();

            if (ManagerBu011_drl.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);

                ManagerBu011_drl.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBu011_drl.SaveInstanceControls, Controls);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bu011_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBu011_drl.ShowOffForm();
        }

        private void tumbler31_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBu011_drl.ClickToButton((Control)sender);
            if(sender is tumbler3)
            {
                var t = (tumbler3)sender;
                if(t.Position == 2)
                {
                    yellowElement1.IsLighting = true;
                    greenElement1.IlLighting = false;
                }
                else if(t.Position == 0)
                {
                    yellowElement1.IsLighting = false;
                    greenElement1.IlLighting = true;
                }
                else
                {
                    yellowElement1.IsLighting = false;
                    greenElement1.IlLighting = false;
                }
            }
        }
    }
}
