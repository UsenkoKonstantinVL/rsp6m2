using System;
using System.Drawing;
using System.Windows.Forms;

namespace indikator_rsp_6m2
{
    public partial class Potenzhiomert : UserControl
    {
        private int Value = 0;
        private int Type = 0;
        private int Angle_Min = 180;
        private int Value_Max = 75;

        public int getValue()
        {
            return trackBar1.Value;
        }

        public int Set_Value
        {
            get { return Value; }
            set { Value = value; BackgroundImage_Change(); OnValueChanged(new SomeEventArgs(Value)); trackBar1.Value = Value; }

        }

        public int Set_Type
        {
            get { return Type; }
            set { Type = value; Invalidate(); }
        }

        public delegate void SomeEventDelegate(object sender, SomeEventArgs e);
        public event SomeEventDelegate Value_Changed;
        protected virtual void OnValueChanged(SomeEventArgs e)
        {
            if (Value_Changed != null)
            { Value_Changed(this, e); }
        }

        public class SomeEventArgs : EventArgs
        {
            private int newValue;
            public SomeEventArgs(int newValue)
            { this.newValue = newValue; }
        }

        public Potenzhiomert()
        { InitializeComponent(); 
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

        public void BackgroundImage_Change()
        {
            int Angle = Convert.ToInt16(Value * 3.6 * Value_Max / 100 + Angle_Min);
            button1.BackgroundImage = rotateImage(indikator_rsp_6m2.Resource1.potenziometr, Angle);
            
        }

        private void Potenzhiometr_Load(object sender, EventArgs e)
        {
            double aux = 0;
            
            switch (Type)
            {
                case 0: aux = 0.6; break;
                case 1: aux = 0.5; break;
            }

            button1.Width =  Convert.ToInt16(aux * Width);
            button1.Height = button1.Width;

            button1.Left = Width / 2 - button1.Width / 2;
            button1.Top = 0;

            trackBar1.Height = 25;
            trackBar1.Width = Width;

            trackBar1.Left = 0;
            trackBar1.Top = button1.Height + button1.Top;
            Height = trackBar1.Top + trackBar1.Height;

            trackBar1.Visible = false;

            BackgroundImage_Change();

           
        }
        string parent = "";
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Value = trackBar1.Value;
            if (this.Parent.Name == "panel1") parent = this.Parent.Parent.Name + "_" + this.Parent.Name;
            else parent = this.Parent.Name;

           
            OnValueChanged(new SomeEventArgs(Value));
           
            BackgroundImage_Change();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = !trackBar1.Visible;
            trackBar1.Enabled = true;
            Cursor.Position = this.PointToScreen(new Point(trackBar1.Width / 2, trackBar1.Top + trackBar1.Height / 2));
            trackBar1.BringToFront();
            //Random r = new Random();
            //trackBar1.Value = r.Next(99);
        }

        private void Potenzhiomert_Leave(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
            trackBar1.Enabled = false;
            
        }
    }
}