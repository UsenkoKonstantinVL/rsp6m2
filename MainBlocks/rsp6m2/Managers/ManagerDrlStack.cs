using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace rsp6m2.Managers
{
    public static class ManagerDrlStack
    {
        static drlStack form = null;
        public static List<Control> AllControlls = null;
        static int ID = 1;

        public static void Initialize()
        {
            //if (form == null)
            {
                form = new drlStack();
            }

            form.Show();

            ManagerHelpForm.GetHelp(ID);

            EmulatorManager.EmulatorManager.SetListenerToQuizeIsDone(ChangeInstance);
            EmulatorManager.EmulatorManager.SetListenerTestIsDone(Dispose);

            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
        }

        public static void SetControls(List<Control> _AllControlls)
        {

            AllControlls = _AllControlls;
            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
           
        }


        public static void Dispose()
        {
            if (form != null && form.isOpened)
                form.Close();
            form = null;
            EmulatorManager.EmulatorManager.QuizeIsDone -= ChangeInstance;
            //SaveInstanceControls = null;
            AllControlls = null;
        }

        public static void ClickToButton(Control control)
        {
            EmulatorManager.EmulatorManager.CheckQuize(control);
            ManagerHelpForm.GetHelp(ID);



            if (control is Button)
            {
                Button b = (Button)control;

                if (b.Name == "button15_drl")
                {
                    Managerbp142.Initialize();
                    return;
                }

                if (b.Name == "buttonIKO")
                {


                    return;
                }

                if (b.Name == "buttonPRL")
                {


                    return;
                }

                if (b.Name == "button4")
                {
                    //drlTop1
                    return;
                }

                if (b.Name == "button5")
                {
                    //prlTop1
                    return;
                }

                if (b.Name == "button7")
                {
                    //drlPwr1
                    return;
                }

                if (b.Name == "buttonIKO")
                {
                    //prlPwr1
                    return;
                }



            }
        }

        public static void ShowOffForm()
        {
            UnlightControls();
            //EmulatorManager.EmulatorManager.QuizeIsDone -= ChangeInstance;
            ManagerHelpForm.GetHelp(0);
        }



        public static void ChangeInstance(List<string> list)
        {
            if (AllControlls != null)
            {
                ManagerHelpForm.GetHelp(ID);
                UnlightControls();
                if (form != null)
                {
                    form.ShowArrow();
                }

                foreach (string controlName in list)
                {
                    foreach (Control c in AllControlls)
                    {
                        if (c.Name == controlName)
                        {
                            {
                                HelpClass.Helper.SetBorderToControl(c);
                                if (form != null)
                                {
                                    form.CloseArrow();
                                }
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
                }

                //form.Invalidate();
            }
        }
    }
}
