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


namespace rsp6m2.Indiacator
{
    public partial class UnderDRLBlocks : genericForm
    {
        public UnderDRLBlocks()
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

            ManagerDRLBlock.SetControls(ilc, lc);

        }

        private void PupBlock_Click(object sender, EventArgs e)
        {

        }

        private void UnderDRLBlocks_Load(object sender, EventArgs e)
        {
            drlblock_bi45.SetTumblerPosition(rsp6m2.Controls.Position.Down);
            drlblock_boi.SetTumblerPosition(rsp6m2.Controls.Position.Down);
            drlblock_buo.SetTumblerPosition(rsp6m2.Controls.Position.Down);
        }

        private void drlblock_bi45_Click(object sender, EventArgs e)
        {
            Tumbler2 cntrl = (Tumbler2)sender;
            ManagerDRLBlock.ClickToButton((Control)sender);
            if (cntrl.Name == "drlblock_bi45")
            {
                if (cntrl.CurrentTumblerPosition() == Position.Up) drlblock_bi45light.SetLight(true);
                else drlblock_bi45light.SetLight(false);
            }

            else if (cntrl.Name == "drlblock_buo")
            {
                if (cntrl.CurrentTumblerPosition() == Position.Up) drlblock_buolight.SetLight(true);
                else drlblock_buolight.SetLight(false);
            }

            else if (cntrl.Name == "drlblock_boi")
            {
                if (cntrl.CurrentTumblerPosition() == Position.Up) drlblock_boilight.SetLight(true);
                else drlblock_boilight.SetLight(false);
            }
        }

        private void UnderdrlBlocks_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerDRLBlock.ShowOffForm();
        }
    }
}
