using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.Managers;
using rsp6m2.HelpClass;

namespace rsp6m2
{
    public partial class bp138 : genericForm
    {
        public bp138()
        {
            InitializeComponent();
            Initialize();

            if (ManagerBp138.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);

                ManagerBp138.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBu011_drl.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bp138.MaxIndex = 9;
            roundTrumbler_bp138.setDrawRoundTumbler(transformPicture);
            roundTrumbler_bp138.CurrentIndex = 4;
        }

        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {
                case 0:
                    alfa = -120;
                    break;
                case 1:
                    alfa = -90;
                    break;
                case 2:
                    alfa = -70;
                    break;
                //case 3:
                //    alfa = 0;
                //    break;
                case 3:
                    alfa = -30;
                    break;
                case 4:
                    alfa = 0;
                    break;
                case 5:
                    alfa = 30;
                    break;
                case 6:
                    alfa = 70;
                    break;
                case 7:
                    alfa = 90;
                    break;
                case 8:
                    alfa = 120;
                    break;
                default:
                    alfa = 120;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }


        #endregion

        private void bp138_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBp138.ShowOffForm();
        }

        private void roundTrumbler1_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBp138.ClickToButton(sender as Control);

            if (roundTrumbler_bp138.CurrentIndex == 0)
            {
                voltmetr1.Set_Value = 10;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 1)
            {
                voltmetr1.Set_Value = 20;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 2)
            {
                voltmetr1.Set_Value = 25;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 3)
            {
                voltmetr1.Set_Value = 40;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 4)
            {
                voltmetr1.Set_Value = 0;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 5)
            {
                voltmetr1.Set_Value = 40;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 6)
            {
                voltmetr1.Set_Value = 25;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 7)
            {
                voltmetr1.Set_Value = 20;
            }
            else if (roundTrumbler_bp138.CurrentIndex == 8)
            {
                voltmetr1.Set_Value = 10;
            }
            else
            {
                voltmetr1.Set_Value = 50;
            }
        }
    }
}
