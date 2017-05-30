using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Managers;
using rsp6m2.HelpClass;
using rsp6m2.Controls;

namespace rsp6m2
{
    public partial class bpchs : genericForm
    {
        public bpchs()
        {
            InitializeComponent();

            Initialize();

            if (ManagerBPCHS.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBPCHS.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBPCHS.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bpchs.MaxIndex = 7;
            roundTrumbler_bpchs.setDrawRoundTumbler(transformPicture);
            roundTrumbler_bpchs.CurrentIndex = 0;
        }

        private void bpchs_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBPCHS.ShowOffForm();
        }

        private void roundTrumbler1_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBPCHS.ClickToButton((Control)sender);
            Random random = new Random();
            if (roundTrumbler_bpchs.CurrentIndex == 4)
            {
                voltmetr1.Set_Value = 12 + random.Next(3) - 2;
            }
            else if (roundTrumbler_bpchs.CurrentIndex == 5)
            {
                voltmetr1.Set_Value = 12 + random.Next(3) - 2;
            }
            else if (roundTrumbler_bpchs.CurrentIndex == 1)
            {
                voltmetr1.Set_Value = 0 + random.Next(2);
            }
            else if (roundTrumbler_bpchs.CurrentIndex == 3)
            {
                voltmetr1.Set_Value = 20 + random.Next(2);
            }
            else
            {
                voltmetr1.Set_Value = 0;
            }
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
                case 3:
                    alfa = 0;
                    break;
                case 4:
                    alfa = 30;
                    break;
                case 5:
                    alfa = 70;
                    break;
                case 6:
                    alfa = 90;
                    break;
                default:
                    alfa = 90;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }


        #endregion
    }
}
