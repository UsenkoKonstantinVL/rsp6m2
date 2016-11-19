using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using rsp6m2.Manager;


namespace rsp6m2.Forms
{
    public partial class HelpForm : Form
    {

        #region ForDraging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public HelpForm()
        {
            InitializeComponent();
        }



        public void GetHelp(TextForHelpForm t)
        {
            var nl = Environment.NewLine;

            labelHelp.Text = "Требуется:" + nl +
                t.NeedClick + nl +
                "Подсказка:" + nl +
                t.HelpText;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
