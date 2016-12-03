using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class RoundTrumbler : UserControl,IResponseForClick, IHighlightControl
    {
        #region Private var
        private int maxIndex = 0;
        private int currentIndex = 0;
        private int sum = +1;
        DrawRoundTumbler drawRoundTumbler;
        public delegate void RedrawBitmap(Tumbler tumbler, Position pos);
        public event SomeEventDelegate ValueChanged;
        #endregion

        #region Public func
        public RoundTrumbler():this(0)
        {
           
        }

        public RoundTrumbler(int maxI):this(maxI, 0)
        {

        }

        public RoundTrumbler(int maxI, int curI)
        {
            InitializeComponent();
            if (maxI < 1)
                maxI = 1;
            maxIndex = maxI;
            currentIndex = curI;
        }


        public int MaxIndex
        {
            set { maxIndex = value; }
        }

        public int CurrentIndex
        {
            set {
                currentIndex = value;
                if (drawRoundTumbler != null)
                { drawRoundTumbler(this, currentIndex);
                } }
            get { return currentIndex; }
        }

        public delegate void DrawRoundTumbler(RoundTrumbler tumbler, int currentIndex);

        public void setDrawRoundTumbler(DrawRoundTumbler d)
        {
            drawRoundTumbler = new DrawRoundTumbler(d);
            drawRoundTumbler(this, currentIndex);
        }

        public void OnValueChanged(SomeEventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(e);
            }
        }

        public void Highlight()
        {
            Graphics g = Graphics.FromImage(this.BackgroundImage);
            Rectangle r1 = new Rectangle(0, 0, BackgroundImage.Width - 1, BackgroundImage.Height - 1);
            g.DrawRectangle(new Pen(Color.Red, 3), r1);
            this.Invalidate();
        }

        public void UnHighlight()
        {

        }

        #endregion

        #region Private func



        private void RoundTrumbler_Load(object sender, EventArgs e)
        {

        }

        public void RoundTrumbler_Click(object sender, EventArgs e)
        {
            int res = currentIndex + sum;
            if(res >= maxIndex)
            {
                sum = -1;
                //currentIndex = maxIndex - 1;
                

            }
            else if(res < 0)
            {
                //currentIndex = 0;
                sum = 1;
                
            }
            currentIndex += sum;
            drawRoundTumbler(this, currentIndex);

            SomeEventArgsTumblerRound ee = new SomeEventArgsTumblerRound(this.Name, currentIndex);
            OnValueChanged(ee);
        }

        #endregion


    }
}
