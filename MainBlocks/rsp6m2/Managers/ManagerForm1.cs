using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using indikator_rsp_6m2;

namespace rsp6m2.Managers
{
    public static class ManagerForm1
    {
        static Form1 form = null;
        public static List<Control> SaveInstanceControls = null;
        public static List<Control> AllControlls = null;
        static int ID = 0;

        static bool selfClosing = false;


        public static void InitializeForm()
        {
            form = new Form1();
            form.Show();

            //ManagerMainForm.CloseForm();
            ManagerHelpForm.GetHelp(ID);

            EmulatorManager.EmulatorManager.SetListenerToQuizeIsDone(ChangeInstance);
            EmulatorManager.EmulatorManager.SetListenerTestIsDone(Dispose);
            /*if(AllControlls != null)
            {
                UnlightControls();
            }*/
            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
        }

        public static void SetControls(List<Control> _SaveInstanceControls, List<Control> _AllControlls)
        {
            SaveInstanceControls = _SaveInstanceControls;
            AllControlls = _AllControlls;
           // UnlightControls();
            ChangeInstance(EmulatorManager.EmulatorManager.GetListOfLightedControls());
        }


        public static void Dispose()
        {
            if(form != null && form.isOpened)
                form.Close();
            selfClosing = true;
            form = null;
            SaveInstanceControls = null;
            AllControlls = null;

        }

        public static void ClickToButton(Control control)
        {
            EmulatorManager.EmulatorManager.CheckQuize(control);
            ManagerHelpForm.GetHelp(ID);


            if (control is Button)
            {
                Button b = (Button)control;

                if(b.Name == "buttonDRL")
                {
                    ManagerDrlStack.Initialize();
                    return;   
                }
                
                if(b.Name == "buttonIKO")
                {
                    indikator_rsp_6m2.Form1 f = new indikator_rsp_6m2.Form1();
                    f.Show();

                    return;
                }

                if (b.Name == "buttonPRL")
                {
                    ManagerPrlStack.Initialize();

                    return;
                }

                if (b.Name == "button4")
                {
                    //drlTop1
                    ManagerDrlTop.Initialize();
                    return;
                }

                if (b.Name == "button5")
                {
                    //prlTop1
                    ManagerPrlTop.Initialize();
                    return;
                }

                if (b.Name == "button6")
                {
                    //drlPwr1
                    ManagerDrlPwr.Initialize();
                    return;
                }

                if (b.Name == "button7")
                {
                    //prlPwr1
                    ManagerPrlPwr.Initialize();
                    return;
                }



            }
        }

        public static void ShowOffForm()
        {
            UnlightControls();
            EmulatorManager.EmulatorManager.QuizeIsDone -= ChangeInstance;
            if (!selfClosing)
            {
                EmulatorManager.EmulatorManager.TestCancel();
                form = null;
                SaveInstanceControls = null;
                AllControlls = null;
            }

            selfClosing = false;
        }

        

        public static void ChangeInstance(List<string> list)
        {
            if (AllControlls != null) {
                ManagerHelpForm.GetHelp(ID);
                UnlightControls();

                foreach (string controlName in list)
                {
                    foreach(Control c in AllControlls)
                    {
                        if(c.Name == controlName)
                        {
                           // if (c is Button)
                            {
                                HelpClass.Helper.SetBorderToControl(c);
                            }
                        }
                    }
                }
                if(form != null)
                    form.Invalidate();
            }

        }

        static void UnlightControls()
        {
            if(AllControlls != null)
            {
                foreach(Control c in AllControlls)
                {
                    if(c != null && c is Button)
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
