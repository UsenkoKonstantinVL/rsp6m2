using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace indikator_rsp_6m2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            voltmetr1.Set_Value = 50;
            nPosSwitch1.setPosNum(12);
            nPosSwitch2.setPosNum(3);
            nPosSwitch3.setPosNum(3);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ikoPasControl1.start();
            ikoDispControl1.start();
            this.Controls.Add(TargManager.Targ1.shortLabl);
            this.Controls.Add(TargManager.Targ1.Labl);
            TargManager.Targ1.shortLabl.BringToFront();
            TargManager.Targ1.Labl.BringToFront();

            this.Controls.Add(TargManager.Targ2.shortLabl);
            this.Controls.Add(TargManager.Targ2.Labl);
            TargManager.Targ2.shortLabl.BringToFront();
            TargManager.Targ2.Labl.BringToFront();

            this.Controls.Add(TargManager.Targ3.shortLabl);
            this.Controls.Add(TargManager.Targ3.Labl);
            TargManager.Targ3.shortLabl.BringToFront();
            TargManager.Targ3.Labl.BringToFront();
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TargManager.refr(radioButton1.Checked);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void potenzhiomert18_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (tumbler17.State)
                ikoDispControl1.angMarker = potenzhiomert18.getValue() * 3.6;

        }

        private void potenzhiomert19_Value_Changed(object sender, Potenzhiomert.SomeEventArgs e)
        {
            if (tumbler17.State)
                ikoDispControl1.rMarker = potenzhiomert19.getValue() * 1.2;
        }

        private void tumbler17_Click(object sender, EventArgs e)
        {
            ikoDispControl1.onMarker = tumbler17.State;
        } 
    }
}
