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
    public partial class bp_apch : genericForm
    {
        ProjectManager p;
        Form f;
        Holder holder;

        public bp_apch(ProjectManager _p, Form _f):this()
        {
            p = _p;
            f = _f;
            //Initialize();
        }

        public bp_apch()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            roundTrumbler_bpch_1.MaxIndex = 5;
            roundTrumbler_bpch_1.setDrawRoundTumbler(transformPicture);

            roundTrumbler_bpch_2.MaxIndex = 5;
            roundTrumbler_bpch_2.setDrawRoundTumbler(transformPicture2);

            List<Control> Controls = new List<Control>();

            foreach(Control c in this.Controls)
            {
                Controls.Add(c);
            }
            holder = new Holder();
            holder.listOfFrom = this;
            holder.listOfControl = Controls;
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

        public void transformPicture2(RoundTrumbler tumbler, int currentIndex)
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

        private void bp_apch_Load(object sender, EventArgs e)
        {
          /*  p.CheckClick((Control)sender);
            p.GetInfo(holder);
            f.Enabled = false;
            voltmetr1.Set_Value = 0;
            voltmetr2.Set_Value = 0;*/
        }

        private void bp_apch_FormClosing(object sender, FormClosingEventArgs e)
        {
          /*  f.Enabled = true;
            p.DeleteInfo();*/
            
        }

        private void roundTrumbler_bpch_2_MouseClick(object sender, MouseEventArgs e)
        {
          /*  p.CheckClick((Control)sender);
            p.GetInfo();*/
        }

        private void roundTrumbler_bpch_1_MouseClick(object sender, MouseEventArgs e)
        {
           /* p.CheckClick((Control)sender);
            p.GetInfo();*/
        }
    }
}
