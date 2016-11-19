using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Forms;
using rsp6m2.Controls;
using rsp6m2.HelpClass;
using rsp6m2.Manager;

namespace rsp6m2
{
    public partial class prlPower : DeskForm
    {

        ProjectManager p;
        Form1 f;
        Holder holder;

        public prlPower(ProjectManager _p, Form1 _f):this()
        {
            p = _p;
            f = _f;
        }

        public prlPower()
        {
            InitializeComponent();
            InitializeHelper();
            roundTrumbler1.MaxIndex = 3;
            roundTrumbler1.setDrawRoundTumbler(transformPicture1);

            roundTrumbler2.MaxIndex = 3;
            roundTrumbler2.setDrawRoundTumbler(transformPicture2);

            roundTrumbler1.CurrentIndex = 3;

            tumbler21.SetTumblerPosition(Position.Down);
            tumbler23.SetTumblerPosition(Position.Down);
        }

        private void InitializeHelper()
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();

            Controls.Add(tumbler11);
            Controls.Add(tumbler12);

            Controls.Add(tumbler21);
            Controls.Add(tumbler22);
            Controls.Add(tumbler23);

            Controls.Add(roundTrumbler1);
            Controls.Add(roundTrumbler2);

            holder.listOfFrom = this;
            holder.listOfControl = Controls;


        }

        //public prlPower()
        //{
        //    InitializeComponent();
        //}


        #region Delegate for RoundTumblers

        public void transformPicture1(RoundTrumbler tumbler, int currentIndex)
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
                default:
                    alfa = 0;
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
                    alfa = 0;
                    break;
                case 1:
                    alfa = 40;
                    break;
                case 2:
                    alfa = 70;
                    break;
                default:
                    alfa = 0;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }

        #endregion

        private void roundTrumbler2_Load(object sender, EventArgs e)
        {

        }

        private void prlPower_Load(object sender, EventArgs e)
        {
            f.Enabled = false;
            p.GetInfo(holder);
        }

        private void prlPower_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled = true;
            p.DeleteInfo();
        }

        private void tumbler11_Click(object sender, EventArgs e)
        {
            p.CheckClick((Control)sender);
            p.GetInfo();
        }

        private void tumbler22_Load(object sender, EventArgs e)
        {

        }

        private void tumbler23_Load(object sender, EventArgs e)
        {

        }

        private void tumbler12_Load(object sender, EventArgs e)
        {

        }
    }
}
