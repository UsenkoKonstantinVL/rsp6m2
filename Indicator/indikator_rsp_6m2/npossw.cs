using System;
using System.Drawing;
using System.Windows.Forms;

namespace indikator_rsp_6m2
{
    public partial class nPosSwitch : UserControl
    {
        public nPosSwitch()
        {
            InitializeComponent();
            this.BackgroundImage = Resource1.perekluchatel;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            draw();
        }
        void draw()
        {
            switch (pos)
            {
                case 2:
                    if (skin == 1)
                    {
                        this.BackgroundImage = rotateImage(Resource1.perekluchatel, 330 + i * 45);
                    }
                    if (skin == 2)
                    {
                        this.BackgroundImage = rotateImage(Resource1.perekluchatel, 270 + 2 * i * 45);
                    }
                    break;

                case 3:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 315 + i * 45);

                    break;
                case 4:
                    if (skin == 1)
                    {
                        this.BackgroundImage = rotateImage(Resource1.perekluchatel, 315 + i * 30);
                    }
                    if (skin == 2)
                    {
                        this.BackgroundImage = rotateImage(Resource1.perekluchatel, 270 + i * 90);
                    }
                    break;
                case 5:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 290 + i * 35);
                    break;
                case 6:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 285 + i * 30);
                    break;
                case 8:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 230 + i * 30);
                    break;
                case 9:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 230 + i * 32);
                    break;
                case 10:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 230 + i * 30);
                    break;
                case 11:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 220 + 28 * i);
                    break;
                case 12:
                    this.BackgroundImage = rotateImage(Resource1.perekluchatel, 220 + 28 * i);
                    break;
            }
            
        }

        public int Step
        {
            set { i = value; }
            get { return i; }
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
    
        public void setPosNum(int _pos)
        {
            pos = _pos; 
        }

        int pos = 4;
        int i = 0;
        public int skin = 1;

        private void UserControl1_Load(object sender, EventArgs e)
        {
            draw();
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            this.Width = this.Width;
            this.Height = this.Height;
        }

        private void nPosSwitch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                i--;
                if (i < 0) i = 0;
                draw();
            }
            if (e.Button == MouseButtons.Left)
            {
                //if (e.Button )
                i++;
                if (i > pos - 1) i = 0;
                draw();
            }
        }



    }
}
