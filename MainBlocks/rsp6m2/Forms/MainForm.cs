using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Manager;
using System.Runtime.InteropServices;

namespace rsp6m2.Forms
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public MainForm()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref m);
            });

            if(!Managers.ManagerMainForm.IsInitialize())
            {
                Managers.ManagerMainForm.Initialize(this);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        Form1 form1;
        HelpForm help;

        private void button1_Click(object sender, EventArgs e)
        {
            /*bool b = radioButton1.Checked;
            var a = listBox1.SelectedIndex;
            ProjectManager pm = new ProjectManager(a, b, this);
            if(b)
            {
                help = new HelpForm();
                help.Show();
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить тумблер 1.";
                t.HelpText = "Закройте прогу и бегите.";
                help.GetHelp(t);
                pm.SetHelpForm(help);
                
            }
            else
            {

            }

            form1 = new Form1(this, pm);

            form1.Show();
            Console.WriteLine("Выбранный индекс - " + a);*/
            var a = listBox1.SelectedIndex;
            EmulatorManager.EmulatorManager.InitializeManager(a, true);
        }

        public void Finish()
        {
            /*this.Enabled = true;
            form1.Close();
            if(help != null)
                help.Close();
            CompleteForm c = new CompleteForm();
            c.ShowDialog();*/
        }

        void Initialize()
        {
            
        }
    }
}
