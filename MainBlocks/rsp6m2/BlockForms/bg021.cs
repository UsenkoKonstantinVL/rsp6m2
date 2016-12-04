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

namespace rsp6m2.BlockForms
{
    public partial class bg021 : genericForm
    {
        public bg021()
        {
            InitializeComponent();
            //TODO: Написать реализацию для тумблеров

            if (ManagerBg021.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);

                ManagerBg021.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBg021.SaveInstanceControls, Controls);
            }
            Initialize();
        }

        void Initialize()
        {
            roundTrumbler_bg021_1.MaxIndex = 3;
            roundTrumbler_bg021_1.setDrawRoundTumbler(transformPicture);

            roundTrumbler_bg021_2.MaxIndex = 4;
            roundTrumbler_bg021_2.setDrawRoundTumbler(transformPicture2);
        }

        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {
                case 0:
                    alfa = -40;
                    break;

                case 1:
                    alfa = 0;
                    break;
                case 2:
                    alfa = 40;
                    break;

                    alfa = 40;
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

        private void bg021_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBg021.ShowOffForm();
        }

        private void roundTrumbler_bg021_1_Click(object sender, EventArgs e)
        {
            ManagerBg021.ClickToButton((Control)sender);

            if(sender is RoundTrumbler)
            {
                var t = (RoundTrumbler)sender;

                if(t.Name == "roundTrumbler_bg021_1")
                {
                    if (t.CurrentIndex == 0)
                    {
                        voltmetr1.Set_Value = 12;
                    }
                    if (t.CurrentIndex == 1)
                    {
                        voltmetr1.Set_Value = 15;
                    }
                    if (t.CurrentIndex == 2)
                    {
                        voltmetr1.Set_Value = 25;
                    }
                }
                else
                {
                    if (t.CurrentIndex == 0)
                    {
                        voltmetr2.Set_Value = 48/2;
                    }
                    if (t.CurrentIndex == 1)
                    {
                        voltmetr2.Set_Value = 49/2;
                    }
                    if (t.CurrentIndex == 2)
                    {
                        voltmetr2.Set_Value = 51/2;
                    }
                    if (t.CurrentIndex == 3)
                    {
                        voltmetr2.Set_Value = 52/2;
                    }
                }
            }
        }
    }
}
