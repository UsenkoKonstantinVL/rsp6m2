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
    public partial class bpr011sm2 : genericForm
    {
        public bpr011sm2()
        {
            InitializeComponent();
            roundTrumbler_bp011sm2.BringToFront();

            Initialize();

            if (ManagerBpr011sm2.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBpr011sm2.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBpr011sm2.SaveInstanceControls, Controls);
            }

            //if (Helper.isBPRReady)
            {
                greenElement1.IlLighting = true;
                yellowElement1.IsLighting = true;
            }
        }

        private void bpr011sm2_Load(object sender, EventArgs e)
        {
            
        }

        private void greenElement1_Load(object sender, EventArgs e)
        {

        }

        void Initialize()
        {
            roundTrumbler_bp011sm2.MaxIndex = 6;
            roundTrumbler_bp011sm2.setDrawRoundTumbler(transformPicture);
            roundTrumbler_bp011sm2.CurrentIndex = 0;
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
                    alfa = 90;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }


        #endregion

        private void bpr011sm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBpr011sm2.ShowOffForm();
        }

        private void roundTrumbler_bp011sm2_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBpr011sm2.ClickToButton((Control)sender);
            if (roundTrumbler_bp011sm2.CurrentIndex == 3)
            {
                voltmetr1.Set_Value = 18;
            }
            else if (roundTrumbler_bp011sm2.CurrentIndex == 4)
            {
                voltmetr1.Set_Value = 20;
            }
            else
            {
                voltmetr1.Set_Value = 0;
            }
        }
    }
}
