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
    public partial class bop : genericForm
    {
        public bop()
        {
            InitializeComponent();
            Initialize();

            if (ManagerBop.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBop.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBop.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bop_1.MaxIndex = 5;
            roundTrumbler_bop_1.setDrawRoundTumbler(transformPicture);

            roundTrumbler_bop_2.MaxIndex = 3;
            roundTrumbler_bop_2.setDrawRoundTumbler(transformPicture2);

            roundTrumbler_bop_3.MaxIndex = 3;
            roundTrumbler_bop_3.setDrawRoundTumbler(transformPicture2);

            tumblerbop_1.SetTumblerPosition(Position.Down);


        }

        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {
                case 0:
                    alfa = -60;
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
                    alfa = 60;
                    break;
                default:
                    alfa = 60;
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
                    alfa = -30;
                    break;

                case 1:
                    alfa = 0;
                    break;
                case 2:
                    alfa = 30;
                    break;
                default:
                    alfa = 30;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }
        #endregion

        private void bop_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBop.ShowOffForm();
        }

        private void tumblerbop_1_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
            if (tumblerbop_1.CurrentTumblerPosition() == Position.Up)
            {
                lightbop_norma.SetLight(true);
            }

            else
            {
                lightbop_norma.SetLight(false);
            }
        }
    }
}
