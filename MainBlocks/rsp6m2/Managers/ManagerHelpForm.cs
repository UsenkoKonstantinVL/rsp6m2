using System;
using System.Collections.Generic;
using System.Text;
using rsp6m2.Forms;
using rsp6m2.Manager;
namespace rsp6m2.Managers
{
    static public class ManagerHelpForm
    {
        static HelpForm help = null;
        static Dictionary<int, TextForHelpForm> ListOfHelp;

        public static void InitializeForm()
        {
            help = new HelpForm();
            help.Show();
        }

        public static void SetHelp(TextForHelpForm text)
        {
            if (help != null)
            {
                help.GetHelp(text);
            }
        }

        public static void SetHelp(Dictionary<int, TextForHelpForm> _ListOfHelp)
        {
            if (help != null)
            {
                ListOfHelp = _ListOfHelp;
            }
        }

        public static void GetHelp(int IDofControl)
        {
            if(help != null)
            {
                if (ListOfHelp.ContainsKey(IDofControl))
                {
                    help.GetHelp(ListOfHelp[IDofControl]);
                }
                else
                {
                    help.GetHelp(ListOfHelp[-1]);
                }
            }
        }

        public static void CloseHelp()
        {
            if(help != null)
            {
                help.Close();
                help = null;
            }
        }
    }
}
