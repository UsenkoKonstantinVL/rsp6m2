using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.Managers;
using rsp6m2;

namespace indikator_rsp_6m2
{
    public partial class UnderPRLBlocks : genericForm
    {
        public UnderPRLBlocks()
        {
            InitializeComponent();

            List<Control> lc = new List<Control>();
            List<Control> ilc = new List<Control>();

            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    lc.Add(c);
                }
                else if (c is Tumbler)
                {
                    lc.Add(c);
                    ilc.Add(c);
                }
                else if (c is RoundTrumbler)
                {
                    lc.Add(c);
                    ilc.Add(c);
                }
                else if (c is Light)
                {
                    lc.Add(c);
                    ilc.Add(c);
                }

            }

            ManagerPRLBlock.SetControls(ilc, lc);
            ManagerPRLBlock.ClickToButton((Control)prlblock_boi);
        }

        private void PupBlock_Click(object sender, EventArgs e)
        {

        }

        private void UnderPRLBlocks_Load(object sender, EventArgs e)
        {
            Position pos = Position.Down;
            foreach (var contrl in Controls)
            {
                if (contrl is Tumbler1)
                {
                    var tempC = (Tumbler1)contrl;
                    tempC.SetTumblerPosition(pos);
                }
                else if (contrl is Tumbler2)
                {
                    var tempC = (Tumbler2)contrl;
                    tempC.SetTumblerPosition(pos);
                }
            }
            //prlblock_bi45.SetTumblerPosition(rsp6m2.Controls.Position.Down);
            //prlblock_boi.SetTumblerPosition(rsp6m2.Controls.Position.Down);
            //prlblock_buo.SetTumblerPosition(rsp6m2.Controls.Position.Down);
        }

        private void prlblock_bi45_Click(object sender, EventArgs e)
        {
            Tumbler2 cntrl = (Tumbler2)sender;
            ManagerPRLBlock.ClickToButton((Control)sender);
            if(cntrl.Name == "prlblock_bi45")
            {
                if (cntrl.CurrentTumblerPosition() == Position.Up) prlblock_bi45light.SetLight(true);
                else prlblock_bi45light.SetLight(false);
            }

            else if (cntrl.Name == "prlblock_buo")
            {
                if (cntrl.CurrentTumblerPosition() == Position.Up) prlblock_buolight.SetLight(true);
                else prlblock_buolight.SetLight(false);
            }

            else if (cntrl.Name == "prlblock_boi")
            {
                if (cntrl.CurrentTumblerPosition() == Position.Up) prlblock_boilight.SetLight(true);
                else prlblock_boilight.SetLight(false);
            }
        }

        private void UnderPRLBlocks_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerPRLBlock.ShowOffForm();
        }
    }
}
