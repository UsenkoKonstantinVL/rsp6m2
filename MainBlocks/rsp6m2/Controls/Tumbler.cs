using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class Tumbler : UserControl, IHighlightControl, IResponseForClick/*, IHighlight*/
    {
        #region Private region var
        Position tumblerPosition;
        Bitmap bmp;
        RedrawBitmap redrawBitmap;
        #endregion

        #region Public var
        public delegate void RedrawBitmap(Tumbler tumbler, Position pos);
        public event SomeEventDelegate ValueChanged;
        #endregion

        #region Public func
        public Tumbler(): this(null)
        {
            /*InitializeComponent();
            tumblerPosition = Position.Up;
            bmp = null;*/
        }

        public Tumbler(Bitmap b)
        {
            InitializeComponent();
            tumblerPosition = Position.Down;
            bmp = b;
        }



        public void Tumbler_Click(object sender, EventArgs e)
        {
            ChangeValueAndRedraw();
            SomeEventArgs ee = new SomeEventArgsTumbler(this.Name, tumblerPosition);
            OnValueChanged(ee);
        }

        public void OnValueChanged(SomeEventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(e);
            }
        }

        public Position CurrentTumblerPosition()
        {
            return tumblerPosition;
        }    

        public void SetTumblerPosition(Position pos)
        {
            tumblerPosition = pos;
            Redraw();
        }

        public void Highlight()
        {
            Graphics g = Graphics.FromImage(this.BackgroundImage);
            Rectangle r1 = new Rectangle(0, 0, BackgroundImage.Width - 1, BackgroundImage.Height - 1);
            g.DrawRectangle(new Pen(Color.Red), r1);
            this.Invalidate();
        }

        public void UnHighlight()
        {

        }

        #endregion


        #region Private func
        private void ChangeValueAndRedraw()
        {
            if (tumblerPosition == Position.Up)
            {
                tumblerPosition = Position.Down;
            }
            else
            {
                tumblerPosition = Position.Up;
            }
            Redraw();
        }

        private void Redraw()
        {
            if (redrawBitmap != null)
                redrawBitmap(this, tumblerPosition);
            //DrawBitmap();
        }

        private void DrawBitmap()
        {

        }
        #endregion

        #region Protected 
        protected Position TumblerPosition
        {
            get
            {
                return tumblerPosition;
            }

            set
            {
                tumblerPosition = value;
                Redraw();
            }
        }


        protected Bitmap Bmp
        {
            get
            {
                return bmp;
            }

            set
            {
                bmp = value;
            }
        }

        protected void SetRedrawDelegate(RedrawBitmap delegat)
        {
            redrawBitmap = new RedrawBitmap(delegat);
            redrawBitmap(this, tumblerPosition);
        }

        protected void  ChangeValue()
        {
            ChangeValueAndRedraw();
            Redraw();
        }

        #endregion
    }

    public enum Position
    {
        Up, Down
    }
}
