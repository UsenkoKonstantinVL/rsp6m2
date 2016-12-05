using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class Bigbutton : UserControl
    {
        public Bigbutton()
        {
            InitializeComponent();
        }

        public void Highlight()
        {
            
                Graphics g = Graphics.FromImage(this.BackgroundImage);
                Rectangle r1 = new Rectangle(0, 0, BackgroundImage.Width - 1, BackgroundImage.Height - 1);
                g.DrawRectangle(new Pen(Color.Red, 10), r1);
                this.Invalidate();
            
        }
    }
}
