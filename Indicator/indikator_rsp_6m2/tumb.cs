using System;
using System.Drawing;
using System.Windows.Forms;
namespace indikator_rsp_6m2
{
    public partial class tumbler : UserControl
    {
        public tumbler()
        {
            InitializeComponent();
          
                if (sided)
                {
                    if (!isOn) this.BackgroundImage = rotateImage(sw, 90);
                    else this.BackgroundImage = rotateImage(sw, 270);
                }
                else
                {
                    if (!isOn)
                        this.BackgroundImage = rotateImage(sw, 180);
                    else
                        this.BackgroundImage = rotateImage(sw, 0);
                }
        
        }
        public int Set_Skin
        {
            get { return skin; }
            set { skin = value;  }
        }
        Bitmap sw = new Bitmap(Resource1.tmb);
        bool isOn = false;
        bool sided = false;
        int skin = 1;
        public void Setskin(int skin_id)
        {
            skin = skin_id;
            switch (skin_id)
            {
                case 1:
                    sw = (Resource1.tmb);
                    break;
                case 2:
                    sw = (Resource1.tmb);
                    break;
                case 3:
                    sw = (Resource1.tmb);
                    break;
                default:
                    sw = (Resource1.tmb);
                    break;
            }
        }
        public bool isSided
        {
            get { return sided; }
            set { sided = value;  }
        }
        public bool State
        {
            get { return isOn; }
            set { isOn = value; }
        }
      
        private Bitmap rotateImage(Bitmap input, int angle)
        {
            Bitmap result = new Bitmap(input.Width, input.Height);
            Graphics g = Graphics.FromImage(result);
            g.TranslateTransform((float)input.Width / 2, (float)input.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)input.Width / 2, -(float)input.Height / 2);
            g.DrawImage(input, new Point(0, 0));
            return result;
        }
        private void tumbler_Click(object sender, EventArgs e)
        {
            if (skin != 3)
            {
                if (sided)
                {
                    if (!isOn)   this.BackgroundImage = rotateImage(sw, 90);
                    else        this.BackgroundImage = rotateImage(sw, 270);
                }
                else
                {
                    if (!isOn)
                        this.BackgroundImage = rotateImage(sw, 180);
                    else
                        this.BackgroundImage = rotateImage(sw, 0);
                }
            }
            isOn = !isOn;
            if (skin == 3)
            {
                if (isOn) this.BackgroundImage = Resource1.tmb;
                else this.BackgroundImage = Resource1.tmb;
            }
        }

        private void tumbler_Load(object sender, EventArgs e)
        {
            if (sided)
            {
                if (isOn) 
                    this.BackgroundImage = rotateImage(sw, 270);
                else
                    this.BackgroundImage = rotateImage(sw, 90);
            }
            if (!sided)
            {
                if (isOn)
                    this.BackgroundImage = rotateImage(sw, 180);
                else
                    this.BackgroundImage = rotateImage(sw, 0);
            }
        }
    }
}
