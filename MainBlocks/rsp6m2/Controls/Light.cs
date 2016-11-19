using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class Light : UserControl
    {
        public Light()
        {
            InitializeComponent();
            SetLight(false);
        }

        public delegate void LightChanged(object sender, bool isLight);

        public LightChanged onLightChanged;

        public void SetLight(bool b)
        {
            if(b)
            {
                this.BackgroundImage = Properties.Resources.lampgr;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.lamp;
            }
        }

        public bool isLight()
        {
            return light;
        }
        bool light = false;
        public void LightOn()
        {
            this.BackgroundImage = Properties.Resources.lampgr;
            onLightChanged(this, true);
            light = true;

        }

        public void LightOff()
        {
            this.BackgroundImage = Properties.Resources.lamp;
            onLightChanged(this, false);
            light = false;
        }
    }
}
