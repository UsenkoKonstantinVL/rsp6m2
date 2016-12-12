using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Forms
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Enabled = false;
            //Hide();
            //this.Visible = false;
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }
    }
}
