using rsp6m2.Controls;
using rsp6m2.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.BlockForms
{
    public partial class bg021 : Form
    {
        public bg021()
        {
            InitializeComponent();
            //TODO: Написать реализацию для тумблеров

            if (ManagerBg021.AllControlls == null)
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

                ManagerBg021.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBg021.SaveInstanceControls, Controls);
            }
        }

        private void bg021_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBg021.ShowOffForm();
        }
    }
}
