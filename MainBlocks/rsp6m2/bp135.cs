using rsp6m2.Controls;
using rsp6m2.HelpClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2
{
    public partial class bp135 : genericForm
    {
        public bp135()
        {
            InitializeComponent();
        }

        private void bp135_Load(object sender, EventArgs e)
        {
            //TODO: init Voltmeter
            roundTumbler1.MaxIndex = 5;
            roundTumbler1.setDrawRoundTumbler(transformPicture);
            
        }
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
    }
}
