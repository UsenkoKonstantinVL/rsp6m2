using System;
using System.Drawing;
using System.Windows.Forms;

namespace indikator_rsp_6m2
{
    public partial class ikoDispControl : UserControl
    {
        public ikoDispControl()
        {
            InitializeComponent();
        }

        public int brightness = 6;
        public int sizeLigt = 17;
        double angle = 0;
        int rx, ry = 0;
        int x0 = 250, y0 = 250;
        double r = 170;
      public  int Zoom =1 ;
        double SpeedIKO = 4;

        public void start()
        {
          timer1.Interval = 100;
            timer1.Start();
        }

        public void stop()
        {
            timer1.Stop();
        }
        Brush Br = new SolidBrush(Color.Azure);
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void IKO_control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
               TargManager.Targ1.ShowLabl(angle);
               TargManager.Targ2.ShowLabl(angle);
               TargManager.Targ3.ShowLabl(angle);
            }
        }

        double mouseAz;
        double mouseDal;
        private void IKO_control_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X - x0;
            int Y = e.Y - y0;
            mouseDal =( Math.Sqrt (X * X + Y * Y) );
            mouseAz = Convert.ToInt16((50 / Math.PI) * Math.Atan2(Y, X)) + 75;
            mouseAz = mouseAz - 50;
            mouseAz = mouseAz * 36 / 10;
            if (mouseAz < 0) mouseAz = mouseAz + 360;
            //label1.Text =Convert.ToInt32(mouseAz).ToString();
            //label2.Text = Convert.ToInt32(mouseDal).ToString();
            //label3.Text = (TargManager.Targ3.Step.ToString() + " " + TargManager.Targ3.az.ToString() + "_" + TargManager.Targ3.dal.ToString()).ToString();
            TargManager.Targ1.ShowLabl(mouseAz);
            TargManager.Targ2.ShowLabl(mouseAz);
            TargManager.Targ3.ShowLabl(mouseAz);
        }
        public double rMarker = 0;
        public double angMarker = 0;
        public bool onMarker = false;
        void DrawMarker(Graphics canvas)
        {
            if (onMarker)
            {
                int MarkX = Convert.ToInt32(rMarker * Math.Cos((angMarker - 90) * Math.PI / 180)) + x0;
                int MarkY = Convert.ToInt32(rMarker * Math.Sin((angMarker - 90) * Math.PI / 180)) + y0;
                label1.Left = MarkX;
                label1.Top = MarkY;
                label1.Text = angMarker.ToString();
                canvas.DrawLine(new Pen(Brushes.GreenYellow), x0, y0, MarkX, MarkY);
            }
            else
            {
                label1.Left = 999;
            }
        }

        private void IKO_control_Paint(object sender, PaintEventArgs e)
        {
           
            rx = Convert.ToInt32(r * Math.Cos((angle - 90) * Math.PI / 180)) + x0;
            ry = Convert.ToInt32(r * Math.Sin((angle - 90) * Math.PI / 180)) + y0;
            Graphics canvas = e.Graphics;
            DrawMarker(canvas);
            Brush brush = new SolidBrush(Color.FromArgb(126, 132, 95));
            TargManager.Targ1.drawDisp(x0 - 30, y0 - 30, e, r, angle);
            TargManager.Targ2.drawDisp(x0 - 30, y0 - 30, e, r, angle);
            TargManager.Targ3.drawDisp(x0 - 30, y0 - 30, e, r, angle);
            canvas.DrawLine(new Pen(Br, 1 + (brightness - 1) / (sizeLigt + 8)), x0, y0, rx, ry);
            for (int i = 5; i < 15; i++)
            {
                int step = 15 * Zoom ;
                canvas.DrawArc(new Pen(Brushes.GreenYellow), 20 + step * i, 20 + step * i, 460 - step * 2 * i, 460 - step * 2 * i, Convert.ToInt32(angle - 95), 5);
            }
         /*   for (int i = 3; i < 5; i++)
            {
                int step = 50;
                canvas.DrawArc(new Pen(Brushes.GreenYellow), 20 + step * i, 20 + step * i, 460 - step * 2 * i, 460 - step * 2 * i, Convert.ToInt32(angle - 110), 10);
            }
          */  Pen PenKorob = new Pen(Brushes.GreenYellow);
            int rPas = 90 * 2/3 * Zoom;
            int anglPas = 45;
            int Perenos = 45 * 2/3 * Zoom;
            canvas.DrawLine(PenKorob, Convert.ToInt32(x0 + rPas * Math.Cos((anglPas - 90) * Math.PI / 180)), Convert.ToInt32(y0 + rPas * Math.Sin((anglPas - 90) * Math.PI / 180)), Convert.ToInt32(rPas * Math.Cos((anglPas + 180 - 90) * Math.PI / 180)) + x0, Convert.ToInt32(rPas * Math.Sin((anglPas + 180 - 90) * Math.PI / 180)) + y0);
            canvas.DrawLine(PenKorob, Convert.ToInt32(x0 + Perenos + rPas * Math.Cos((anglPas - 90) * Math.PI / 180)), Convert.ToInt32(y0 + Perenos + rPas * Math.Sin((anglPas - 90) * Math.PI / 180)), Convert.ToInt32(rPas * Math.Cos((anglPas + 180 - 90) * Math.PI / 180)) + x0 + Perenos, Convert.ToInt32(rPas * Math.Sin((anglPas + 180 - 90) * Math.PI / 180)) + y0 + Perenos);
            canvas.DrawLine(PenKorob, Convert.ToInt32(x0 + rPas * Math.Cos((anglPas - 90) * Math.PI / 180)), Convert.ToInt32(y0 + rPas * Math.Sin((anglPas - 90) * Math.PI / 180)), Convert.ToInt32((rPas + 15) * Math.Cos((anglPas + 35 - 90) * Math.PI / 180)) + x0, Convert.ToInt32((rPas + 15) * Math.Sin((anglPas + 35 - 90) * Math.PI / 180)) + y0);
            canvas.DrawLine(PenKorob, Convert.ToInt32(x0 + rPas * Math.Cos((anglPas + 180 - 90) * Math.PI / 180)), Convert.ToInt32(y0 + rPas * Math.Sin((anglPas + 180 - 90) * Math.PI / 180)), Convert.ToInt32((rPas + 15) * Math.Cos((anglPas + 180 - 35 - 90) * Math.PI / 180)) + x0, Convert.ToInt32((rPas + 15) * Math.Sin((anglPas + 180- 35 - 90) * Math.PI / 180)) + y0);
            angle = angle + SpeedIKO;
            if (angle > 359) angle = 0;
        }
    }
}