using System;
using System.Drawing;
using System.Windows.Forms;
namespace indikator_rsp_6m2
{
    public class target
    {
        public double az;
        public double dal;
        public double alt;
        public int num;
        public bool showInfo;
        Random Rnd = new Random();
        int bortNum;
        int feel;
        public  Label shortLabl = new Label();
        public  Label Labl = new Label();
        int allign = -1;
      public  double speed = 0.1;
        double[,] dalTrack = new double[5, 15];
        double[,] azTrack = new double[5, 15];
        public int numTrack;
      
        public int Step = 0;
        

        public target(int _num, int _az, int _dal, int _numTrack, int _align = 1, bool _show = true)
        {
            Random Rnd = new Random(_az);
            az = _az;
            numTrack = _numTrack;
            dal = _dal;
            allign = _align;
            num = _num;
            bortNum = Rnd.Next(10000, 99999);
            feel = Rnd.Next(100, 999);

            dalTrack[0, 0] = 90;
            azTrack[0, 0] = 45;
            dalTrack[0, 1] = 0;
            azTrack[0, 1] = 55;

            dalTrack[1, 0] = 90;
            azTrack[1, 0] = 224;
            dalTrack[1, 1] = 95;
            azTrack[1, 1] = 190;
            dalTrack[1, 2] = 70;
            azTrack[1, 2] = 115;
            dalTrack[1, 3] = 77;
            azTrack[1, 3] = 90;
            dalTrack[1, 4] = 106;
            azTrack[1, 4] = 84;
            dalTrack[1, 5] = 100;
            azTrack[1, 5] = 55;
            dalTrack[1, 6] = 0;
            azTrack[1, 6] = 55;

            dalTrack[2, 0] = 160;
            azTrack[2, 0] = 7;
            dalTrack[2, 1] = 121;
            azTrack[2, 1] = 25;
            dalTrack[2, 2] = 95;
            azTrack[2, 2] = 40;
            dalTrack[2, 3] = 61;
            azTrack[2, 3] = 72;
            dalTrack[2, 4] = 60;
            azTrack[2, 4] = 115;
            dalTrack[2, 5] = 74;
            azTrack[2, 5] = 162;
            dalTrack[2, 6] = 88;
            azTrack[2, 6] = 184;
            dalTrack[2, 7] = 94;
            azTrack[2, 7] = 205;
            dalTrack[2, 8] = 82;
            azTrack[2, 8] = 223;
            dalTrack[2, 9] = 41;
            azTrack[2, 9] = 223;
            dalTrack[2, 10] = 1;
            azTrack[2, 10] = 220;

            dalTrack[3, 0] = 90;
            azTrack[3, 0] = 45 + 180;
            dalTrack[3, 1] = 0;
            azTrack[3, 1] = 55 +180;

            dalTrack[4, 0] = 177;
            azTrack[4, 0] = 130;
            dalTrack[4, 1] = 160;
            azTrack[4, 1] = 101;
            dalTrack[4, 2] = 164;
            azTrack[4, 2] = 79;
            dalTrack[4, 3] = 182;
            azTrack[4, 3] = 65;
            dalTrack[4, 4] = 214;
            azTrack[4, 4] = 50;
            dalTrack[4, 5] = 260;
            azTrack[4, 5] = 40;
            dalTrack[4, 6] = 999;
            azTrack[4, 6] = 40;
            initLabl();
        }
        bool ShowSw = false;
        public void ShowLabl(double angl)
        {
            if (angl > az - 10 && angl < az + 30)
            {
                ShowSw = !ShowSw;
                if (ShowSw)
                {
                    Labl.Show();
                    shortLabl.Text = bortNum.ToString() + " " + num.ToString();
                }
                if (!ShowSw)
                {
                    Labl.Hide();
                    shortLabl.Text = "00000 " + num.ToString();
                }
            }
        }

        void initLabl()
        {
            shortLabl.AutoSize = true;
            shortLabl.Font = new System.Drawing.Font("BatangChe", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            shortLabl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            shortLabl.Location = new System.Drawing.Point(170, 193 + 15 * num);
            shortLabl.Name = "targ" + num.ToString();
            shortLabl.BackColor = Color.Transparent;
            shortLabl.Size = new System.Drawing.Size(77, 14);
            shortLabl.Text = "00000 " + num.ToString();

            Labl.Font = new System.Drawing.Font("BatangChe", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Labl.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            Labl.Name = "Targ" + num.ToString();
            Labl.Size = new System.Drawing.Size(70, 30);
            Labl.Location = new System.Drawing.Point(999, 193 + 15 * num);
            Labl.TabIndex = 0;
            Labl.BackColor = Color.Transparent;
            Labl.Text = num.ToString() + " " + bortNum.ToString() + "\r\n" + "A  " + feel.ToString();
            Labl.Hide();
        }

        public void newTarg()
        {
            az = az + Rnd.Next(70);
            bortNum = Rnd.Next(1000, 9999);
            feel = Rnd.Next(100, 999);
            shortLabl.Text = bortNum.ToString() + " " + num.ToString();
            Labl.Text = num.ToString() + " " + bortNum.ToString() + "\r\n" + "A  " + feel.ToString();
        }

        void draw_lable(int x0, int y0,PaintEventArgs e)
        {
            x0 = 250;
            y0 = 250;
            int rx = Convert.ToInt32(dal * Zoom * Math.Cos((az - 90) * Math.PI / 180)) + x0;
            int ry = Convert.ToInt32(dal * Zoom * Math.Sin((az - 90) * Math.PI / 180)) + y0;
              Graphics canvas = e.Graphics;
              //canvas.DrawLine(new Pen(Brushes.GreenYellow),rx, ry, x0,y0);
              Labl.Location = new Point(rx + 30 , ry - 20);
        }
        double Zoom = 0.66;
        public void drawDisp(int x0, int y0, PaintEventArgs e, double r, double angle)
        {if ( dal < 220)
         //  if (angle > az - 40 && angle < az + 40)
            {
               
                draw_lable(x0, y0,e);
                Graphics canvas = e.Graphics;
                canvas.DrawArc(new Pen(Brushes.GreenYellow), 250 - Convert.ToInt32(dal * Zoom), 250 - Convert.ToInt32(dal * Zoom), Convert.ToInt32(dal * Zoom) * 2, Convert.ToInt32(dal * Zoom) * 2, Convert.ToInt32(az - 100), Convert.ToInt32(900 / (dal * Zoom + 1)));
            }
         // else
            {
                move(r);
            }
        }
        int y(int x)
        {
            int f;
            f = Convert.ToInt32(Math.Log(x));
            return f;
        }
        public void drawPas( PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            double Zoom = 0.75;
            int X1sm = 80;
            int Y1sm = 250;
            double GainX1 = 5 * Zoom;
            double GainY1 = 50 * Zoom;
            int X2sm = 80;
            int Y2sm = 350;
            double GainX2 = 5 * Zoom;
            double GainY2 = 25 * Zoom;
                double x = dal;
            if ( dal > 3 && dal < 65)
            {
                if (Math.Abs(az - 51) < 9  )
                {
                    canvas.DrawRectangle(new Pen(Brushes.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X1sm + 15), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x - 1)), 1, 7);
                    if (dal < 10)
                    {
                        canvas.DrawRectangle(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x ) + X2sm), Y2sm - Convert.ToInt32(GainY2 * Math.Log(x )), 1, 7);

                        canvas.DrawRectangle(new Pen(Brushes.GreenYellow), Convert.ToInt32(GainX1 * (x) + X1sm + 10), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x)), 1, 7);
                    }
                    canvas.DrawRectangle(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X2sm), Y2sm - Convert.ToInt32(GainY2 * Math.Log(x - 1)), 1, 7);
                    
                }
                if (Math.Abs(az - 227) < 9)
                {
                    if (dal < 10)
                    {
                        canvas.DrawRectangle(new Pen(Brushes.GreenYellow), Convert.ToInt32(GainX1 * (x) + X1sm + 10), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x)), 1, 7);
                        canvas.DrawRectangle(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x ) + X2sm), Y2sm - 150 + Convert.ToInt32(GainY2 * Math.Log(x )), 1, 7);
                    }
                    canvas.DrawRectangle(new Pen(Brushes.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X1sm + 15), Y1sm - Convert.ToInt32(GainY1 * Math.Log(x - 1)), 1, 7);
                    canvas.DrawRectangle(new Pen(Color.GreenYellow), Convert.ToInt32(GainX1 * (x - 1) + X2sm), Y2sm - 150 + Convert.ToInt32(GainY2 * Math.Log(x - 1)), 1, 7);
                }
            }
            //  move(200);
        }

        void move(double r)
        {
            double k = 1;
            if (dal > dalTrack[numTrack, Step])
            {
                dal = (dal - speed);
                k = 0.5;
            }
            if (dal < dalTrack[numTrack, Step])
            {
                dal = (dal + speed);
                k = 0.5;
            }
            if (az > azTrack[numTrack, Step])
                az = az - k * speed;
            if (az < azTrack[numTrack, Step])
                az = az + k * speed;
            if (Math.Abs(dalTrack[numTrack, Step] - dal) < 1 && Step < 14 && Math.Abs((az) - azTrack[numTrack, Step]) < 1)
                Step++;
            if (dal < 2)
            {
                dal = 2;
                allign = -allign;
            }
        }
    }
}
