using System;
using System.Drawing;
using System.Windows.Forms;
using rsp6m2.Manager;
namespace rsp6m2
{
    public partial class genericForm : Form
    {
        //protected ProjectManager p;
        //public genericForm(ProjectManager _p)
        //{
        //    p = _p;
        //}
        public genericForm()
        {
            InitializeComponent();
            panel1.Visible = false;
        }





        public  bool isOpened = false;
        public byte onStep = 0;
        public bool MegaMain = false;
        private void genericForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MegaMain)
            {
                isOpened = false;
                e.Cancel = true;
                this.Hide();
            }
        }
        private void genericForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                isOpened = false;
                Close();
            }
        }
        private void genericForm_Load(object sender, EventArgs e)
        {
            on = true;
            isOpened = true;

   
        }
        public void draw_str(Control contr)
        {
            
        }
        bool on = true;
        private void genericForm_Activated(object sender, EventArgs e)
        {
            
        }

        public void ShowArrow()
        {
            panel1.Visible = true;
        }

        public void CloseArrow()
        {
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void genericForm_SizeChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point((this.Width - 40 - 20), 0);
        }
    }
}
