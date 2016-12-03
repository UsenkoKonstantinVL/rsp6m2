using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Forms
{
    public partial class CompleteForm : DeskForm
    {
        public CompleteForm()
        {
            InitializeComponent();
            //GetNewName("Тест закончен", "FormComplete");

        }

        public void GetName(String s1, String s2)
        {
            label1.Text = s1;
            GetNewName(s1, s2);
        }
    }
}
