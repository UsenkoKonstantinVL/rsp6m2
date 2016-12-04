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
    public partial class buv_021 : genericForm
    {
        public buv_021()
        {
            InitializeComponent();

            if (ManagerBuv021.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBuv021.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBuv021.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {

        }

        private void buv_021_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBuv021.ShowOffForm();
        }
    }
}
