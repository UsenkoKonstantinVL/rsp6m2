using rsp6m2.Controls;
using rsp6m2.HelpClass;
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
    public partial class bp213 : genericForm
    {
        public bp213()
        {
            InitializeComponent();
            Initialize();

            if (ManagerBp213.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBp213.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBp213.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bp213.MaxIndex = 6;
            roundTrumbler_bp213.setDrawRoundTumbler(transformPicture);
            roundTrumbler_bp213.CurrentIndex = 0;
        }

        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {
                case 0:
                    alfa = -90;
                    break;
                case 1:
                    alfa = -70;
                    break;
                case 2:
                    alfa = -30;
                    break;
                //case 3:
                //    alfa = 0;
                //    break;
                case 3:
                    alfa = 30;
                    break;
                case 4:
                    alfa = 70;
                    break;
                case 5:
                    alfa = 90;
                    break;
                default:
                    alfa = 60;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }


        #endregion

        private void roundTrumbler1_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBp213.ClickToButton((Control)sender);

            if (roundTrumbler_bp213.CurrentIndex == 0)
            {
                voltmetr1.Set_Value = 0;
            }
            else if (roundTrumbler_bp213.CurrentIndex == 1)
            {
                voltmetr1.Set_Value = 21;
            }
            else if (roundTrumbler_bp213.CurrentIndex == 2)
            {   
                voltmetr1.Set_Value = 25;
            }
            else if (roundTrumbler_bp213.CurrentIndex == 3)
            {
                voltmetr1.Set_Value = 25;
            }
            else if (roundTrumbler_bp213.CurrentIndex == 4)
            {
                voltmetr1.Set_Value = 40;
            }
            else if (roundTrumbler_bp213.CurrentIndex == 5)
            {
                voltmetr1.Set_Value = 40;
            }
            else
            {
                voltmetr1.Set_Value = 50;
            }
        }

        private void bp213_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBp213.ShowOffForm();
        }
    }
}
