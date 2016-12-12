using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Managers
{
    public static class ManagerPrlStack
    {
        static prlStack form = null;
        public static List<Control> AllControlls = null;
        static int ID = 4;

        public static void Initialize()
        {
            //if (form == null)
            {
                form = new prlStack();
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

                if (b.Name == "button28_prl")
                {
                    ManagerBpApch.Initialize();
                    return;
                }

                if (b.Name == "button6_prl")
                {
                    ManagerBu011.Initialize();

                    return;
                }

                if (b.Name == "button24_prl")
                {
                    ManagerBg021.Initialize();

                    return;
                }

                if (b.Name == "button21_prl")
                {
                    ManagerBpr021.Initialize();
                    //drlTop1
                    return;
                }

                if (b.Name == "button13_prl")
                {
                    ManagerBvm011.Initialize();
                    //prlTop1
                    return;
                }

                if (b.Name == "button16_prl")
                {
                    //drlPwr1
                    ManagerBuv021.Initialize();
                    return;
                }

                if (b.Name == "button1_prl")
                {
                    //prlPwr1
                    ManagerBop.Initialize();
                    return;
                }

                

                    if (b.Name == "button2_prl")
                {
                    //prlPwr1
                    ManagerBSF.Initialize();
                    return;
                }

                if (b.Name == "button10_prl")
                {
                    //prlPwr1
                    ManagerBprn021.Initialize();
                    return;
                }
                if (b.Name == "button17_prl")
                {
                    //prlPwr1
                    ManagerBp127.Initialize();
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
                }

                //form.Invalidate();
            }
        }
    }
}
