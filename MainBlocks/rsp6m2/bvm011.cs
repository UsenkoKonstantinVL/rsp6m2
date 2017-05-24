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
            Initialize();

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
            roundTrumbler_bvm011_2.CurrentIndex = 3;

            roundTrumbler_bvm011_1.MaxIndex = 4;
            roundTrumbler_bvm011_1.setDrawRoundTumbler(transformPicture);

            voltmetr2.Set_Value = 1;
            voltmetr1.Set_Value = 2;

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

            Random rng = new Random();
            // Предположим, что здесь много логики
            

            if (roundTrumbler_bvm011_1.CurrentIndex == 0)
            {
                voltmetr2.Set_Value = 1 + rng.Next(2) - 1;
            }
            if (roundTrumbler_bvm011_1.CurrentIndex == 1)
            {
                voltmetr2.Set_Value = 3 + rng.Next(2) - 1;
            }

            if (roundTrumbler_bvm011_1.CurrentIndex == 2)
            {
                voltmetr2.Set_Value = 5 + rng.Next(2) - 1;
            }

            if (roundTrumbler_bvm011_1.CurrentIndex == 3)
            {
                voltmetr2.Set_Value = 10 + rng.Next(4) - 2;
            }
        }

        private void roundTrumbler_bvm011_2_Click(object sender, EventArgs e)
        {
            if(((Control)sender).Name == "roundTrumbler_bvm011_2")
            {
                Random rng = new Random();
                if (roundTrumbler_bvm011_2.CurrentIndex == 0)
                {
                    voltmetr1.Set_Value = 2 + rng.Next(2) - 1; ;
                }
                if (roundTrumbler_bvm011_2.CurrentIndex == 1)
                {
                    voltmetr1.Set_Value = 8 + rng.Next(2) - 1; ;
                }

                if (roundTrumbler_bvm011_2.CurrentIndex == 2)
                {
                    voltmetr1.Set_Value = 15 + rng.Next(6) - 3; 
                }

                if (roundTrumbler_bvm011_2.CurrentIndex == 3)
                {
                    voltmetr1.Set_Value = 30 + rng.Next(9) - 5; 
                }

            }
            ManagerBvm011.ClickToButton((Control)sender);
        }

        private void bvm011_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBvm011.ShowOffForm();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
        }

        private void bigbutton1_bvm011_1_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
        }

        private void bigbutton1_bvm011_2_Load(object sender, EventArgs e)
        {

        }

        private void bigbutton1_bvm011_2_Click(object sender, EventArgs e)
        {
            ManagerBvm011.ClickToButton((Control)sender);
        }

        private void bigbutton1_Load(object sender, EventArgs e)
        {

        }
    }
}
