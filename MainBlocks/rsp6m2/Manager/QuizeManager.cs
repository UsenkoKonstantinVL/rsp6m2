using System;
using System.Collections.Generic;
using System.Text;
using rsp6m2.Controls;
using System.Windows.Forms;
using rsp6m2.Forms;
using rsp6m2.HelpClass;

namespace rsp6m2.Manager
{
    public class QuizeManager
    {
        private List<Quiz> QuizList;
        private int CurrentQuiz = 0;
        private HelpForm helpForm;

        public delegate void QuizEnd();
        public QuizEnd quizeEnd;

        public QuizeManager(int i)
        {

            QuizList = new List<Quiz>();
            NewHelpClass n = new NewHelpClass();
            QuizList = n.GetQuiz(0);//n.GetQuiz(i);
        }

        public void GetHelp(HelpForm h)
        {
            helpForm = h;
        }

        public bool isQuizDone(Control clickedControl)
        {
            if(QuizList.Count > CurrentQuiz)
            {
                if(QuizList[CurrentQuiz].isQuizDone(clickedControl))
                {
                    CurrentQuiz++;
                    if(QuizList.Count <= CurrentQuiz)
                    {
                        QiuzFinish();
                    }
                    return true;
                }
            }
            return false;
        }
        public void checkForm(Holder currentHolder)
        {
            if (QuizList.Count > CurrentQuiz)
            {
                QuizList[CurrentQuiz].checkCurrentForm(currentHolder, helpForm);         
            }
        }


        private void QiuzFinish()
        {
            quizeEnd();
        }

        private List<Quiz> GetQuizs()
        {
            List<Quiz> quizs = new List<Quiz>();

            Quiz quiz = new Quiz("Name", new Quiz.QuizIsDone(QuizIsNotDone), new Quiz.CheckForm(CheckForm));
            quizs.Add(quiz);


            return quizs;
        }

        public bool QuizIsNotDone(Control clickedControl)
        {
            if(clickedControl.Name == "tumbler11")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }
            return false;
        }

        public void CheckForm(Holder currentHolder, HelpForm helpForm)
        {

            var Controls = currentHolder.listOfControl;

            foreach(var control in Controls)
            {
                if(control.Name == "tumbler11")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }
            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить тумблер 1.";
                t.HelpText = "Вы открыли нужное окно.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить тумблер 1.";
                t.HelpText = "Нажмите на любую кнопку.";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить тумблер 1.";
                t.HelpText = "Бегите.";
                helpForm.GetHelp(t);
            }
        }

    }
}
