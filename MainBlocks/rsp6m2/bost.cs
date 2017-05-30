using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.HelpClass;
using rsp6m2.Controls;
using rsp6m2.Managers;

namespace rsp6m2
{
    public partial class bost : genericForm
    {
        public bost()
        {
            InitializeComponent();

            if(Helper.bostLightOn == true)
            {
                foreach(var contrl in Controls)
                {
                    if(contrl is Light)
                    {
                        var l = contrl as Light;
                        l.SetLight(true);
                    }
                }
            }

            ManagerBOST.ClickToButton(light1_drl as Control);
        }

        private void bost_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBOST.ShowOffForm();
        }
    }
}
