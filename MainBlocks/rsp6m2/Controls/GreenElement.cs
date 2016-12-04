using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class GreenElement : UserControl
    {
        public GreenElement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool isLight = false;

        public bool IlLighting { get { return isLight; }
            set {
                isLight = value;

                if(isLight == true)
                {
                    BackColor = Color.ForestGreen;
                }
                else
                {
                    BackColor = Color.LightGreen;
                }
                ; } }


        private void GreenElement_Load(object sender, EventArgs e)
        {

        }
    }
}
