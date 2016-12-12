using rsp6m2.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;

namespace rsp6m2.BlockForms
{
    public partial class buv_021 : genericForm
    {
        public buv_021()
        {
            InitializeComponent();
            Initialize();
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
            tumbler22.SetTumblerPosition(Position.Down);
            tumbler_buc021_1.SetTumblerPosition(Position.Down);
        }

        private void buv_021_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBuv021.ShowOffForm();
        }

        public void IsLampLighting(bool res)
        {
            if(res)
            {
                light_buv021_1.SetLight(res);
            }
                    
        }

        public void SetValueToVoltmatre3(int value)
        {
            voltmetr3.Set_Value = value;
        }

        private void tumbler21_Click(object sender, EventArgs e)
        {

        }

        private void tumbler_buc021_1_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
            if (tumbler_buc021_1.CurrentTumblerPosition() == Position.Up)
            {
                light_buv021_vn.SetLight(true);
            }
            else
            {
                light_buv021_vn.SetLight(false);
            }
        }

        private void tumbler_buv021_1_Click(object sender, EventArgs e)
        {
            
        }

        private void tumbler_buv021_1_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);

            if (tumbler_buv021_1.Position == 0)
            {
                voltmetr1.Set_Value = 25;
            }
            if (tumbler_buv021_1.Position == 2)
            {
                voltmetr1.Set_Value = 0;
            }
        }
    }
}
