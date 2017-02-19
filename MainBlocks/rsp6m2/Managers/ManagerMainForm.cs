using System;
using System.Collections.Generic;
using System.Text;
using rsp6m2.Forms;

namespace rsp6m2.Managers
{
    public static class ManagerMainForm
    {
        static MainForm form = null;

        public static void Initialize()
        {
            form = new MainForm();
            form.Show();
        }

        public static void Initialize(MainForm _form)
        {
            form = _form;
        }

        public static void CloseForm()
        {
            form.Close();
        }

        public static void FormShow()
        {
            if(form.Visible == false)
            {
                form.Visible = true;
            }
        }

        public static bool IsInitialize()
        {
            if(form == null)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
