﻿using System;
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
    public partial class drlTop : genericForm
    {

        ProjectManager p;
        Form f;
        Holder holder;

        public drlTop(ProjectManager _p, Form _f)  
        {
            p = _p;
            f = _f;
            InitializeComponent();
            InitializeHelper();

            tumblerVoltage_drltop.SetTumblerPosition(Position.Down);
            tumblerventilate_drltop.SetTumblerPosition(Position.Down);
            tumblerIndicate_drltop.SetTumblerPosition(Position.Down);

            roundTrumbler_drltop.MaxIndex = 4;
            roundTrumbler_drltop.setDrawRoundTumbler(transformPicture);
        }

        private void InitializeHelper()
        {
            List<Control> Controls;
            holder = new Holder();
            Controls = new List<Control>();

            Controls.Add(tumblerVoltage_drltop);
            Controls.Add(tumblerIndicate_drltop);
            Controls.Add(tumblerventilate_drltop);


            Controls.Add(roundTrumbler_drltop);

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
                    alfa = 30;
                    break;
                case 3:
                    alfa = 50;
                    break;
                default:
                    alfa = -30;
                    break;
            }
            tumbler.BackgroundImage = HelpFunctionClass.RotateImage(tumbler.BackgroundImage as Bitmap, alfa);
            tumbler.Invalidate();
        }
        #endregion

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void drlTop_Load(object sender, EventArgs e)
        {
            p.CheckClick((Control)sender);
            p.GetInfo(holder);
            f.Enabled = false;
            voltmetr1.Set_Value = 30;
        }

        private void drlTop_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Enabled = true;
            p.DeleteInfo();
        }

        private void tumblerVoltage_drltop_Load(object sender, EventArgs e)
        {

        }

        private void tumblerIndicate_drltop_Load(object sender, EventArgs e)
        {
           
        }

        private void tumblerventilate_drltop_Load(object sender, EventArgs e)
        {

        }

        private void tumblerventilate_drltop_Click(object sender, EventArgs e)
        {
            p.CheckClick((Control)sender);
            p.GetInfo();
        }
    }
}
