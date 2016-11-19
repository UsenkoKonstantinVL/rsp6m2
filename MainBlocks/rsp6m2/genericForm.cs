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
         //FormManager.hlp.hlpRefresh(this.Name + "_Off");
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
            /*if (FormManager.hlp.helpActive)
            {
                str.Location = new System.Drawing.Point(contr.Location.X + contr.Size.Width - 8, contr.Location.Y + contr.Size.Height - 8);
            }*/
        }
        bool on = true;
        private void genericForm_Activated(object sender, EventArgs e)
        {
            /*
            if (on)
            {
                on = false;
                FormManager.hlp.hlpRefresh(this.Name + "_On");
                if ( FormManager.hlp.helpEnabled())
                FormManager.hlp.hlp_show(this);
              
            }
             * */
        }
    }
}
