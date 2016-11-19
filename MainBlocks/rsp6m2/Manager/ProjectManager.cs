using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using rsp6m2.Forms;
using rsp6m2.Controls;

namespace rsp6m2.Manager
{
    public class ProjectManager
    {
        #region Private var
        private QuizeManager quizManager;
        private List<Holder> listOfControlsAndForms;
        bool isWithTraining = false;
        MainForm mainForm;
        #endregion

        #region Public func

        public ProjectManager(int numOfQuiz, bool training,  MainForm m, HelpForm h) : this(numOfQuiz,  training, m)
        {
            SetHelpForm(h);
        }

        public ProjectManager(int numOfQuiz, bool training, MainForm m)
        {
            if (numOfQuiz < 0)
            {
                numOfQuiz = 0;
            }
            listOfControlsAndForms = new List<Holder>();
            quizManager = new QuizeManager(numOfQuiz);
            quizManager.quizeEnd = new QuizeManager.QuizEnd(TestComplite);
            mainForm = m; 
            isWithTraining = training;
            ListClickedControl = new List<Control>();
            InitializeComponent();
        }



        public void SetHelpForm(HelpForm h)
        {
            quizManager.GetHelp(h);
        }

        public void GetInfo(Holder currentHolder)
        {
            if (isWithTraining)
            {
                CheckControls(currentHolder.listOfControl);
                listOfControlsAndForms.Add(currentHolder);
                SetInfo();  
                Console.WriteLine("Сохраняю в память...");
            }
        }

        private void CheckControls(List<Control> c)
        {
            foreach (Control cc in c)
            {
                bool ishere = false;
                foreach (Control cn in ListClickedControl)
                {
                    if (cc.Name == cn.Name)
                    {
                        ishere = true;
                        switch(cc.GetType().ToString())
                        {
                            case "rsp6m2.Controls.Tumbler1":
                            case "rsp6m2.Controls.Tumbler2":
                                {
                                    ((Tumbler)cc).SetTumblerPosition(((Tumbler)cn).CurrentTumblerPosition());
                                    cn.Click -= listenClick;
                                    cc.Click += listenClick;
                                    break;
                                }

                            case "rsp6m2.Controls.RoundTrumbler":
                                {
                                    ((RoundTrumbler)cc).CurrentIndex = ((RoundTrumbler)cn).CurrentIndex;
                                    cn.Click -= listenClick;
                                    cc.Click += listenClick;
                                    break;
                                }
                            case "rsp6m2.Controls.Light":
                            {
                                    ((Light)cc).SetLight(((Light)cn).isLight());
                                    ((Light)cn).onLightChanged -= CheckLight;
                                    ((Light)cc).onLightChanged += CheckLight;
                                    break;
                            }
                        }
                    }
                }

                if(!ishere)
                {
                    if (cc.GetType().ToString() == "rsp6m2.Controls.Tumbler1" || cc.GetType().ToString() == "rsp6m2.Controls.Tumbler2" || cc.GetType().ToString() == "rsp6m2.Controls.RoundTrumbler")
                    {
                        cc.Click += listenClick;
                        ListClickedControl.Add(cc);
                    }
                    else if(cc.GetType().ToString() == "rsp6m2.Controls.Light")
                    {
                        ((Light)cc).onLightChanged += CheckLight;
                        ListClickedControl.Add(cc);
                    }
                }
            }
        }

        private void CheckLight(object sender, bool light)
        {
            foreach (Control c in ListClickedControl)
            {
                if (c.Name == ((Control)sender).Name)
                {

                       ((Light)c).SetLight(light);
                }
            }
        }
         
        List<Control> ListClickedControl;

        private void SetClickListener(List<Control> c)
        {
            foreach(Control control in c)
            {
                if(control.GetType().ToString() == "rsp6m2.Controls.Tumbler1" || control.GetType().ToString() == "rsp6m2.Controls.Tumbler2" || control.GetType().ToString() == "rsp6m2.Controls.RoundTrumbler")
                {
                    control.Click += listenClick;
                    ListClickedControl.Add(control);
                }
            }
        }

        private void AddControlToList(Control c)
        {
           
            //foreach (Control cc in c)
            {
                bool ishere = false;
                foreach (Control cn in ListClickedControl)
                {
                    if (c.Name == cn.Name)
                    {
                        ishere = true;
                       // break;
                    }
                }
                if (!ishere)
                {
                    ListClickedControl.Add(c);
                    c.Click += listenClick;
                }
            }

            
        }

        private void listenClick(object sender, EventArgs e)
        {
            foreach(Control c in ListClickedControl)
            {
                if(c.Name == ((Control)sender).Name)
                {
                    switch (((Control)sender).GetType().ToString())
                    {
                        case "rsp6m2.Controls.Tumbler1":
                        case "rsp6m2.Controls.Tumbler2":
                            ((Tumbler)c).SetTumblerPosition(((Tumbler)sender).CurrentTumblerPosition());
                            break;

                        case "rsp6m2.Controls.RoundTrumbler":
                            ((RoundTrumbler)c).CurrentIndex = ((RoundTrumbler)sender).CurrentIndex;
                            break;
                    }
                }
            }
        }


        public void GetInfo()
        {
            if (isWithTraining)
            {
                SetInfo();
                Console.WriteLine("Сохраняю в память...");
            }
        }

        public void DeleteInfo()
        {
            if (isWithTraining) {
                listOfControlsAndForms.RemoveAt(listOfControlsAndForms.Count - 1);
                Console.WriteLine("Удаляю из памяти...");
            }
        }

        public void CheckClick(Control clickedControl)
        {
            if(quizManager.isQuizDone(clickedControl))
            {
                if(isWithTraining)
                    SetInfo();
            }
        }
        #endregion


        #region Private func

        private void InitializeComponent()
        {
            mainForm.Enabled = false;
        }

        private void SetInfo()
        {
            quizManager.checkForm(listOfControlsAndForms[listOfControlsAndForms.Count - 1]);
        }

        private void TestComplite()
        {
            Console.WriteLine("Мы здесь!!");
            mainForm.Finish();
        }
        #endregion




    }

    public enum WhatQuiz
    {
        first, second
    }

    public class Holder
    {
        public Form listOfFrom;
        public List<Control> listOfControl;
    }

    public class HighlightControls
    {
        public delegate void HighLightDelegate(HighlightEventArgs args);
        public event HighLightDelegate SetHighLight;

        public delegate void UnHighLightDelegate();
        public event UnHighLightDelegate UnSetHihgLight;


        private void setHighlight(HighlightEventArgs args)
        {
            SetHighLight(args);
        }

        private void unsetHighlight()
        {
            UnSetHihgLight();
        }
    }

   public class HighlightEventArgs:EventArgs
    {
        public List<String> HighLightList;

        public HighlightEventArgs(List<String> l)
        {
            HighLightList = l;
        }
    }


}
