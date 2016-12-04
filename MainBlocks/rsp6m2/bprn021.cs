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
    public partial class bprn021 : genericForm

    {
        public bprn021()
        {
            InitializeComponent();
            Initialize();

            if (ManagerBprn021.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBprn021.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBprn021.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bprn021_2.MaxIndex = 5;
            roundTrumbler_bprn021_2.setDrawRoundTumbler(transformPicture2);

            roundTrumbler_bprn021_1.MaxIndex = 3;

        }

        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {

                case 0:
                    alfa = -30;
                    break;
                case 1:
                    alfa = 0;
                    break;
                case 2:
                    alfa = 30;
                    break;

                default:
                    alfa = 70;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }

        public void transformPicture2(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {
                case 0:
                    alfa = -70;
                    break;
                case 1:
                    alfa = -30;
                    break;
                case 2:
                    alfa = 0;
                    break;
                case 3:
                    alfa = 30;
                    break;
                case 4:
                    alfa = 70;
                    break;
                default:
                    alfa = 70;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }
        #endregion

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
