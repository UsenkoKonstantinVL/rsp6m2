using System;
using System.Drawing;
using System.Windows.Forms;
using rsp6m2.HelpClass;

namespace indikator_rsp_6m2
{
    public partial class ikoPasControl : UserControl
    {
        public ikoPasControl()
        {
            InitializeComponent();
            alt = 155* Zoom;
            //SetColor(0.2);
        }
        double dal = 0;
        double alt ; // высота на уровнем моря по английски altitude
        double SpeedIKODal = 9;
        double SpeedIKOAlt = 9;


        Color currentColor;
        public void SetColor(double percentage)
        {
            if (percentage >= 1.2) percentage = 1.2;

            Color colorMax = Color.GreenYellow;
            Color colorMin = Color.FromArgb(65, 111, 74);

            currentColor = Color.FromArgb((int)(colorMin.R + (colorMax.R - colorMin.R) * percentage),
                (int)(colorMin.G + (colorMax.G - colorMin.G) * percentage),
                (int)(colorMin.B + (colorMax.B - colorMin.B) * percentage));
        }

        public void start()
        {
            timer1.Start();
            timer1.Interval = 100;
        }

        public void stop()
        {
            timer1.Stop();
        }
        int y(int x)
        {
            int  y;
            y = Convert.ToInt32( Math.Log(x)) ;
            return y;
        }
        void DrawExp(Graphics G)
        {
            int X1sm = 80;
            int Y1sm = 250;
            double GainX1 = 5 * Zoom;
            double GainY1 = 50* Zoom;
            int X2sm = 80;
            int Y2sm = 350;
            double GainX2 = 5 * Zoom;
            double GainY2 = 25 * Zoom;
            for (int x = 4; x < 60; x = x + 1) // просисовка глиссад
            {
                G.DrawLine(new Pen(currentColor), Convert.ToInt32(GainX1 * (x - 1) + X1sm), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x - 1)), Convert.ToInt32(GainX1 * (x) +X1sm), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x)));
                G.DrawLine(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X1sm +30), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x - 1)), Convert.ToInt32(GainX1 * (x) + X1sm + 30), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x)));
                G.DrawLine(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X2sm), Y2sm - Convert.ToInt32(GainY2 * Math.Log(x - 1)), Convert.ToInt32(GainX2 * (x) + X2sm), Y2sm - Convert.ToInt32(GainY2 * Math.Log(x)));
                G.DrawLine(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X2sm ), Y2sm -150  + Convert.ToInt32(GainY2 * Math.Log(x - 1)), Convert.ToInt32(GainX2 * (x) + X2sm), Y2sm -150  + Convert.ToInt32(GainY2 * Math.Log(x)));
            }
        }
        public bool ctrl = false;
        Brush brush = new SolidBrush(Color.FromArgb(126, 132, 95));
        Color ColorLine = Color.Black;
        Pen P = new Pen(Color.GreenYellow);
        Brush Br = new SolidBrush(Color.Azure);
        
        private void timer1_Tick(object sender, EventArgs e)
        {
          this.Invalidate();
        }
        double Zoom = 0.75;
        private void IKO_control_Paint(object sender, PaintEventArgs e)
        {
            if (Helper.isPRLWork)
            {
                Graphics canvas = e.Graphics;

                //  canvas.FillRectangle(brush, 90, 90,Convert.ToInt32( 320 * Zoom),Convert.ToInt32( 320 * Zoom));
                TargManager.Targ1.drawPas(e);
                TargManager.Targ2.drawPas(e);
                TargManager.Targ3.drawPas(e);
                canvas.DrawLine(P, 90, 90, 90, Convert.ToInt32(Zoom * 440));

                canvas.DrawLine(P, 90, Convert.ToInt32(280 * Zoom), Convert.ToInt32(Zoom * 440), Convert.ToInt32(280 * Zoom));
                canvas.DrawLine(P, 90 + Convert.ToInt32(80 * Zoom), 90, 90 + Convert.ToInt32(80 * Zoom), Convert.ToInt32(440 * Zoom));
                for (int i = 4; i < 8; i++)
                    canvas.DrawLine(P, 90 + Convert.ToInt32(40 * i * Zoom), 90, 90 + Convert.ToInt32(40 * i * Zoom), Convert.ToInt32(Zoom * 440));
                canvas.DrawLine(new Pen(Br), 90, Convert.ToInt32(90 + dal), Convert.ToInt32(Zoom * 440), Convert.ToInt32(90 + dal));
                canvas.DrawLine(new Pen(Br), 90, Convert.ToInt32(280 * Zoom + alt), Convert.ToInt32(Zoom * 440), Convert.ToInt32(280 * Zoom + alt));
                DrawExp(canvas);
                dal = dal + SpeedIKODal;
                alt = alt - SpeedIKOAlt;
                if (dal > 155 * Zoom || dal < 3) SpeedIKODal = -SpeedIKODal;
                if (alt < 3 || alt > 155 * Zoom) SpeedIKOAlt = -SpeedIKOAlt;
            }
        }
    }
}