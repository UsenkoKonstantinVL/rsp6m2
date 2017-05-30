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
    public partial class bp127_drl : genericForm
    {
        public bp127_drl()
        {
            InitializeComponent();
            Initialize();

            if (ManagerBp127_drl.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBp127_drl.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBp127_drl.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bp127_drl.MaxIndex = 7;
            roundTrumbler_bp127_drl.setDrawRoundTumbler(transformPicture);
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
                    alfa = 60;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }

        
        #endregion

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bp127_Load(object sender, EventArgs e)
        {

        }

        private void bp127_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBp127_drl.ShowOffForm();
        }

        private void roundTrumbler_bp127_MouseClick(object sender, MouseEventArgs e)
        {
            ManagerBp127_drl.ClickToButton((Control)sender);

            Random rnd = new Random();
            uncheckLight();
            if (roundTrumbler_bp127_drl.CurrentIndex == 0)
            {
                voltmetr2.Set_Value = 0;
            }
            else if (roundTrumbler_bp127_drl.CurrentIndex == 1)
            {
                light15.SetLight(true);
                voltmetr2.Set_Value = 20 - 2 + rnd.Next(4);
            }
            else if (roundTrumbler_bp127_drl.CurrentIndex == 2)
            {
                light14.SetLight(true);
                voltmetr2.Set_Value = 20 + rnd.Next(4) - 2;
            }
            else if (roundTrumbler_bp127_drl.CurrentIndex == 3)
            {
                light13.SetLight(true);
                voltmetr2.Set_Value = 37 + rnd.Next(4) - 2;
            }
            else if (roundTrumbler_bp127_drl.CurrentIndex == 4)
            {
                light12.SetLight(true);
                voltmetr2.Set_Value = 37 + rnd.Next(4) - 2;
            }
            else if (roundTrumbler_bp127_drl.CurrentIndex == 0)
            {
                light11.SetLight(true);
                voltmetr2.Set_Value = 50 + rnd.Next(4) - 2;
            }
            else if (roundTrumbler_bp127_drl.CurrentIndex == 0)
            {
                light10.SetLight(true);
                voltmetr2.Set_Value = 50 + rnd.Next(4) - 2;
            }
        }

        void uncheckLight()
        {
            bool l = false;
            light10.SetLight(l);
            light11.SetLight(l);
            light12.SetLight(l);
            light13.SetLight(l);
            light14.SetLight(l);
            light15.SetLight(l);
        }
    }
}
