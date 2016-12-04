using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.HelpClass;
using rsp6m2.Manager;

namespace rsp6m2
{
    public partial class bpr021 : genericForm
    {
        ProjectManager p;
        Form f;
        Holder holder;

        public bpr021(ProjectManager _p, Form _f):this()
        {
            p = _p;
            f = _f;
            Initialize();
        }

        public bpr021()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
           /* roundTrumbler_bpch_1.MaxIndex = 5;
            roundTrumbler_bpch_1.setDrawRoundTumbler(transformPicture);*/

            //roundTrumbler_bpch_1.MaxIndex = 5;
           // roundTrumbler_bpch_1.setDrawRoundTumbler(transformPicture);

            List<Control> Controls = new List<Control>();

            foreach (Control c in this.Controls)
            {
                Controls.Add(c);
            }
            holder = new Holder();
            holder.listOfFrom = this;
            holder.listOfControl = Controls;

            voltmetr1.Set_Center_str = "mA";
        }


        #region Delegate for RoundTumblers

        public void transformPicture(RoundTrumbler tumbler, int currentIndex)
        {
            int alfa = 0;
            switch (currentIndex)
            {
                case 0:
                    alfa = -50;
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
                    alfa = 50;
                    break;
                default:
                    alfa = 50;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }
        #endregion
    }
}
