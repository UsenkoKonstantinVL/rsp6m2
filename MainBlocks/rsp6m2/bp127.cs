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
    public partial class bp127 : genericForm
    {
        public bp127()
        {
            InitializeComponent();

            if (ManagerBp127.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBp127.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBp127.SaveInstanceControls, Controls);
            }
        }

        void Initialize()
        {
            roundTrumbler_bp127.MaxIndex = 7;
            roundTrumbler_bp127.setDrawRoundTumbler(transformPicture);
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
            ManagerBp127.ShowOffForm();
        }
    }
}
