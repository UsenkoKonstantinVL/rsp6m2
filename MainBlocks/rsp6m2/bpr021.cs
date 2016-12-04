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
using rsp6m2.Managers;

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

            if (ManagerBpr021.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);

                ManagerBpr021.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBpr021.SaveInstanceControls, Controls);
            }
        }

        private void Initialize()
        {
            /* roundTrumbler_bpch_1.MaxIndex = 5;
             roundTrumbler_bpch_1.setDrawRoundTumbler(transformPicture);*/

            //roundTrumbler_bpch_1.MaxIndex = 5;
            // roundTrumbler_bpch_1.setDrawRoundTumbler(transformPicture);

            roundTumbler_bpr021.MaxIndex = 5;
            roundTumbler_bpr021.setDrawRoundTumbler(transformPicture);

            List<Control> Controls = new List<Control>();

            foreach (Control c in this.Controls)
            {
                Controls.Add(c);
            }
            holder = new Holder();
            holder.listOfFrom = this;
            holder.listOfControl = Controls;

            //voltmetr1.Set_Center_str = "mA";
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
        #endregion

        private void tumbler21_Click(object sender, EventArgs e)
        {
            ManagerBpr021.ClickToButton((Control)sender);
        }

        private void roundTrumbler1_Click(object sender, EventArgs e)
        {
            ManagerBpr021.ClickToButton((Control)sender);

            if(roundTumbler_bpr021.CurrentIndex == 0)
            {
                voltmetr1.Set_Value = 23;
            }

            if (roundTumbler_bpr021.CurrentIndex == 1)
            {
                voltmetr1.Set_Value = 23;
            }

            if (roundTumbler_bpr021.CurrentIndex == 2)
            {
                voltmetr1.Set_Value = 23;
            }

            if (roundTumbler_bpr021.CurrentIndex == 3)
            {
                voltmetr1.Set_Value = 23;
            }

        }

        private void bpr021_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerBpr021.ShowOffForm();
        }

        private void bpr021_Load(object sender, EventArgs e)
        {

        }
    }
}
