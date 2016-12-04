using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class YellowElement : UserControl
    {
        public YellowElement()
        {
            InitializeComponent();
        }

        bool isLighting = false;
        public bool IsLighting { get {return isLighting; }
            set {
                isLighting = value;
                if(isLighting)
                {
                    BackColor = Color.Yellow;

                }
                else
                {
                    BackColor = Color.LightYellow;
                }
                ; } }

    }
}
