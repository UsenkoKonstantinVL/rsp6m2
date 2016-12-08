using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using rsp6m2.Controls;

namespace rsp6m2.Managers
{
    public static class ManagerBvm011
    {
        static bvm011 form = null;
        public static List<Control> AllControlls = null;
        public static List<Control> SaveInstanceControls = null;
        static int ID = 413;

        public static void Initialize()
        {
            //if (form == null)
            {
                form = new bvm011();
            }

            form.Show();

            ManagerHelpForm.GetHelp(ID);

            EmulatorManager.EmulatorManager.SetListenerToQuizeIsDone(ChangeInstance);
            EmulatorManager.EmulatorManager.SetListenerTestIsDone(Dispose);

            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
        }

        public static void SetControls(List<Control> _SaveInstanceControls, List<Control> _AllControlls)
        {
            SaveInstanceControls = _SaveInstanceControls;
            AllControlls = _AllControlls;
            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
        }




        public static void Dispose()
        {
            if (form != null && form.isOpened)
            {
                form.Close();
            }
            // form.Close();
            form = null;
            //SaveInstanceControls = null;
            AllControlls = null;
        }

        public static void ClickToButton(Control control)
        {
            EmulatorManager.EmulatorManager.CheckQuize(control);
            ManagerHelpForm.GetHelp(ID);

            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
            if (control is Button)
            {
                Button b = (Button)control;





            }
        }

        public static void ShowOffForm()
        {
            UnlightControls();
            ManagerHelpForm.GetHelp(4);
        }



        public static void ChangeInstance(List<string> list)
        {
            if (AllControlls != null)
            {
                ManagerHelpForm.GetHelp(ID);
                UnlightControls();

                foreach (string controlName in list)
                {
                    foreach (Control c in AllControlls)
                    {
                        if (c.Name == controlName)
                        {
                            {
                                HelpClass.Helper.SetBorderToControl(c);
                            }
                        }
                    }
                }
                if (form != null)
                    form.Invalidate();
            }

        }

        static void UnlightControls()
        {
            if (AllControlls != null)
            {
                foreach (Control c in AllControlls)
                {
                    if (c is Button)
                    {
                        Button b = (Button)c;
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderSize = 0;
                    }
                    if(c is Bigbutton)
                    {
                        Bigbutton b = (Bigbutton)c;
                        b.UnHighlight();
                    }
                }

                //form.Invalidate();
            }
        }
    }
}
