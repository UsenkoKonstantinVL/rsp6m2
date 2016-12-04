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
    public partial class bu011 : genericForm
    {
        public bu011()
        {
            InitializeComponent();

            if (ManagerPrlPwr.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);

                ManagerPrlPwr.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerPrlPwr.SaveInstanceControls, Controls);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bu011_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBu011.ShowOffForm();
        }

        private void tumbler31_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBu011.ClickToButton((Control)sender);
            if(sender is tumbler3)
            {
                var t = (tumbler3)sender;
                if(t.Position == 2)
                {
                    yellowElement1.IsLighting = true;
                    greenElement1.isLight = false;
                }
                else if(t.Position == 0)
                {
                    yellowElement1.IsLighting = false;
                    greenElement1.isLight = true;
                }
                else
                {
                    yellowElement1.IsLighting = false;
                    greenElement1.isLight = false;
                }
            }
        }
    }
}
