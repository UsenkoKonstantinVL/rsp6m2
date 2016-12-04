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
    public partial class bvm011 : genericForm
    {
        public bvm011()
        {
            InitializeComponent();

            if (ManagerBvm011.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBvm011.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBvm011.SaveInstanceControls, Controls);
            }
        }

        private void Initialize()
        {
            /*roundTrumbler_bpch_1.MaxIndex = 5;
            roundTrumbler_bpch_1.setDrawRoundTumbler(transformPicture);*/

            roundTrumbler_bvm011_2.MaxIndex = 4;
            roundTrumbler_bvm011_2.setDrawRoundTumbler(transformPicture2);

            roundTrumbler_bvm011_1.MaxIndex = 4;
            roundTrumbler_bvm011_1.setDrawRoundTumbler(transformPicture);

           
        }

        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
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
                    alfa = 30;
                    break;
                case 3:
                    alfa = 70;
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
                    alfa = 30;
                    break;
                case 3:
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

        private void voltmetr2_Load(object sender, EventArgs e)
        {

        }

        private void roundTrumbler_bvm011_1_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
        }

        private void roundTrumbler_bvm011_2_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
        }

        private void bvm011_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBvm011.ShowOffForm();
        }
    }
}
