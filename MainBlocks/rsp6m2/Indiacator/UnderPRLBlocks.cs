using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace indikator_rsp_6m2
{
    public partial class UnderPRLBlocks : Form
    {
        public UnderPRLBlocks()
        {
            InitializeComponent();
            
        }

        private void PupBlock_Click(object sender, EventArgs e)
        {

        }

        private void UnderPRLBlocks_Load(object sender, EventArgs e)
        {
            bi45Tumbler.SetTumblerPosition(rsp6m2.Controls.Position.Down);
            boimTumbler.SetTumblerPosition(rsp6m2.Controls.Position.Down);
            buoTumbler.SetTumblerPosition(rsp6m2.Controls.Position.Down);
        }
    }
}
