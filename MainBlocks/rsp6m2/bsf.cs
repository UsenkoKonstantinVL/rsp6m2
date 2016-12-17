using rsp6m2.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.EmulatorManager;

namespace rsp6m2
{
    public partial class bsf : genericForm 
    {
        public bsf()
        {
            InitializeComponent();

            if (ManagerBSF.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBSF.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBSF.SaveInstanceControls, Controls);
            }

            bool res = (GlobalManager.BSFisOn1Complect == true);

            light1.SetLight(res);
            light2.SetLight(res);
            light3.SetLight(res);
            light4.SetLight(res);
            light5.SetLight(res);
        }

        private void bsf_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBSF.ShowOffForm();
        }
    }
}
