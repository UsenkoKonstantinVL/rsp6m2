using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Controls
{
    public partial class Tumbler1 : Tumbler
    {
        #region PrivateRegion
        private int width, height;
        #endregion

        #region Public func
        public Tumbler1(): this(Position.Up)
        {
            //InitializeComponent();
        }

        public Tumbler1(Position pos)
        {
            InitializeComponent();
            width = Properties.Resources.Tumbler1On.Width;
            height = Properties.Resources.Tumbler1On.Height;
            base.TumblerPosition = pos;
            
            //Добавить картинку
            base.SetRedrawDelegate(RedrawControl);
        }
        #endregion

        #region Private func




        private void Tumbler1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tumbler1_Load(object sender, EventArgs e)
        {
            base.Width = width;
            base.Height = height;
        }

        #endregion

        #region Public func
        public void RedrawControl(Tumbler tumbler, Position pos)
        {
            if(pos == Position.Up)
            {
                tumbler.BackgroundImage = Properties.Resources.Tumbler1On;
            }
            else
            {
                tumbler.BackgroundImage = Properties.Resources.Tumbler1Off;
            }
        }
        #endregion

        ///Создать Евент
    }
}
