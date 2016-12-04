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

            if (ManagerBpApch.AllControlls == null)
            {
                List<Control> lc = new List<Control>();
                List<Control> ilc = new List<Control>();

                HelpClass.Helper.ListsOfControls(lc, ilc, Controls);


                ManagerBpApch.SetControls(ilc, lc);
            }
            else
            {
                HelpClass.Helper.ReplaceControls(ManagerBpApch.SaveInstanceControls, Controls);
            }
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
            ManagerBpApch.ShowOffForm();
            
        }

        private void roundTrumbler_bpch_2_MouseClick(object sender, MouseEventArgs e)
        {
            /*  p.CheckClick((Control)sender);
              p.GetInfo();*/
            ManagerBpApch.ClickToButton((Control)sender);
        }

        private void roundTrumbler_bpch_1_MouseClick(object sender, MouseEventArgs e)
        {
            /* p.CheckClick((Control)sender);
             p.GetInfo();*/
            ManagerBpApch.ClickToButton((Control)sender);
        }

        private void roundTrumbler_bpch_1_Click(object sender, EventArgs e)
        {
            ManagerBpApch.ClickToButton((Control)sender);
            

            if(sender is RoundTrumbler)
            {
                var t = (RoundTrumbler)sender;

                if(t.Name == "roundTrumbler_bpch_1")
                {
                    if(t.CurrentIndex == 0)
                    {
                        voltmetr1.Set_Value = 0;

                    }

                    if (t.CurrentIndex == 1)
                    {
                        voltmetr1.Set_Value = 12;
                    }

                    if (t.CurrentIndex == 2)
                    {
                        voltmetr1.Set_Value = 12;
                    }

                    if (t.CurrentIndex == 3)
                    {
                        voltmetr1.Set_Value = 25;
                    }

                    if (t.CurrentIndex == 4)
                    {
                        voltmetr1.Set_Value = 10;
                    }
                }
                else
                {
                    if (t.CurrentIndex == 0)
                    {
                        voltmetr2.Set_Value = 0;
                    }

                    if (t.CurrentIndex == 1)
                    {
                        voltmetr2.Set_Value = 2;
                    }

                    if (t.CurrentIndex == 2)
                    {
                        voltmetr2.Set_Value = 3;
                    }

                    if (t.CurrentIndex == 3)
                    {
                        voltmetr2.Set_Value = 0;
                    }

                    if (t.CurrentIndex == 4)
                    {
                        voltmetr2.Set_Value = 0;
                    }
                }
            }
        }
    }
}
