using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using rsp6m2.Forms;

namespace rsp6m2.Manager
{
    public class Quiz
    {
        private String toolName;
        private QuizIsDone CheckQuiz;
        private CheckForm CheckCurrentForm;
        private List<String> helper;

        public Quiz(String name, QuizIsDone q, CheckForm c)
        {
            toolName = name;
            CheckQuiz = q;
            CheckCurrentForm = c;
        }
        public String ToolName
        {
            get { return toolName; }
            set { toolName = value; }
        }
        public List<String> Helper
        {
            get { return helper;}
            set { helper = value;}
        }
        public bool isQuizDone(Control clickedControl)
        {
            return CheckQuiz(clickedControl);
        }
        public void checkCurrentForm(Holder currentHolder, HelpForm helpForm)
        {
            CheckCurrentForm(currentHolder, helpForm);
        }


        #region Delegate
        public delegate bool QuizIsDone(Control clickedControl);
        public delegate void CheckForm(Holder currentHolder, HelpForm helpForm);
        #endregion
    }


    public class TextForHelpForm
    {
        public String NeedClick;
        public String HelpText;


    }

}
