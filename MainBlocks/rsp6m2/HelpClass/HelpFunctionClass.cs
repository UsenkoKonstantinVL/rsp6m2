using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using rsp6m2.Manager;
using rsp6m2.Forms;
using System.Windows.Forms;
using rsp6m2.Controls;

namespace rsp6m2.HelpClass
{
    public static class HelpFunctionClass
    {

        public static Bitmap RotateImage(Bitmap input, int angle)
        {
            Console.WriteLine(input.Height.ToString() + " : " + input.Width.ToString());
            Bitmap result = input.Clone() as Bitmap;//new Bitmap(input.Width, input.Height);
            //result.si = result.Size;
            Graphics g = Graphics.FromImage(result);
            g.Clear(Color.Transparent);
            g.TranslateTransform((float)input.Width / 2, (float)input.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)input.Width / 2, -(float)input.Height / 2);
            g.DrawImage(Properties.Resources.tumbler_round, new Point(0, 0));
            //g.DrawImageUnscaled(input, 0, 0);

            Console.WriteLine(input.Height.ToString() + " : " + input.Width.ToString());
            //g.DrawImage(i, x - pictureBox1.Width / 2, y - pictureBox1.Height / 2, w, h);

            return result;
        }

        public static List<Quiz> GetQuiz(int i)
        {
            List<Quiz> quizs = new List<Quiz>();

            Quiz quiz = new Quiz("Name", new Quiz.QuizIsDone(QuizIsNotDone), new Quiz.CheckForm(CheckForm));
            quizs.Add(quiz);


            return quizs;
        }

        public static bool QuizIsNotDone(Control clickedControl)
        {
            return false;
        }

        public static void CheckForm(Holder currentHolder, HelpForm helpForm)
        {
            if(currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить тумблер 1.";
                t.HelpText = "Вы открыли нужное окно.";
                helpForm.GetHelp(t);
            }
            //else if()
            //{

            //}
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить тумблер 1.";
                t.HelpText = "Бегите.";
                helpForm.GetHelp(t);
            }
        }
    }

    public class NewHelpClass
    {
        public  List<Quiz> GetQuiz(int i)
        {
           

            if(i == 1)
            {
                List<Quiz> quizs = new List<Quiz>();

                Quiz quiz = new Quiz("Name", new Quiz.QuizIsDone(QuizIsNotDone), new Quiz.CheckForm(CheckForm));
                quizs.Add(quiz);

                quiz = new Quiz("Name", new Quiz.QuizIsDone(Quiz2IsNotDone), new Quiz.CheckForm(CheckForm2));
                quizs.Add(quiz);

                quiz = new Quiz("Name", new Quiz.QuizIsDone(Quiz3IsNotDone), new Quiz.CheckForm(CheckForm3));
                quizs.Add(quiz);

                quiz = new Quiz("Name", new Quiz.QuizIsDone(Quiz4IsNotDone), new Quiz.CheckForm(CheckForm4));
                quizs.Add(quiz);

                return quizs;
            }
            else
            {
                return GetQuizPRLOn();
            }

            
        }

        #region Quiz 1

        public  bool QuizIsNotDone(Control clickedControl)
        {
            if (clickedControl.Name == "tumbler11")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }
            return false;
        }

        public  void CheckForm(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " тумблер - Тумблер 1";

            foreach (var control in Controls)
            {
                if (control.Name == "tumbler11")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }
            }

            if (currentHolder.listOfFrom.Name == "prlPower")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вы открыли нужное окно.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на любую кнопку.";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Бегите.";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 2

        public bool Quiz2IsNotDone(Control clickedControl)
        {
            if (clickedControl.Name == "tumbler12")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }
            return false;
        }

        public void CheckForm2(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;
            String txt = " тумблер - Тумблер 2";

            foreach (var control in Controls)
            {
                if (control.Name == "tumbler12")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }
            }

            if (currentHolder.listOfFrom.Name == "prlPower")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вы открыли нужное окно.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на любую кнопку.";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Бегите.";
                helpForm.GetHelp(t);
            }
        }

        #endregion

        #region Quiz 3
        public bool Quiz3IsNotDone(Control clickedControl)
        {
            if (clickedControl.Name == "tumbler23")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }
            return false;
        }

        public void CheckForm3(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;
            String txt = " тумблер - 1";

            foreach (var control in Controls)
            {
                if (control.Name == "tumbler23")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }
            }

            if (currentHolder.listOfFrom.Name == "prlPower")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вы открыли нужное окно.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на любую кнопку.";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Бегите.";
                helpForm.GetHelp(t);
            }
        }
        #endregion


        #region Quiz 4

        public bool Quiz4IsNotDone(Control clickedControl)
        {
            if (clickedControl.Name == "roundTrumbler2")
            {
                var c = clickedControl as RoundTrumbler;
                if (c.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        public void CheckForm4(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;
            String txt = " тумблер в положение Положение 3";

            foreach (var control in Controls)
            {
                if (control.Name == "roundTrumbler2")
                {
                    var c = (RoundTrumbler)control;
                    c.Highlight();
                }
            }

            if (currentHolder.listOfFrom.Name == "prlPower")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вы открыли нужное окно.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на любую кнопку.";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Бегите.";
                helpForm.GetHelp(t);
            }
        }

        #endregion

        public List<Quiz> GetQuizPRLOn()
        {
            List<Quiz> quizs = new List<Quiz>();
            Quiz quiz = new Quiz("БП-142", new Quiz.QuizIsDone(QuizIsNotDone_PRLOn), new Quiz.CheckForm(CheckForm_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("БП-142", new Quiz.QuizIsDone(Quiz2IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm2_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz3IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm3_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz4IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm4_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz5IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm5_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz6IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm6_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz7IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm7_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz8IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm8_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz9IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm9_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz10IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm10_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz11IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm11_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz12IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm12_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz13IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm13_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz14IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm14_PRLOn));
            quizs.Add(quiz);

            quiz = new Quiz("ЩП-5 автомат +27 В", new Quiz.QuizIsDone(Quiz15IsNotDone_PRLOn), new Quiz.CheckForm(CheckForm15_PRLOn));
            quizs.Add(quiz);

            return quizs;
        }


        #region Quiz 1

        public bool QuizIsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerPowerPrl")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }
            return false;
        }

        public void CheckForm_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " на БП-142 (стойка СВП-01)" + Environment.NewLine + "тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerPowerPrl")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

               else  if (control.Name == "button15")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }


                else if (control.Name == "buttonDRL")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }
                
            }

            if (currentHolder.listOfFrom.Name == "bp142")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите правый тумблер СЕТЬ-ОТКЛ в положение СЕТЬ";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на ДРЛ";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "drlStack")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Откройте БП-142";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 2

        public bool Quiz2IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerPowerDrl")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }


            return false;
        }

        public void CheckForm2_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " на БП-142 (стойка СВП-01) тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerPowerDrl")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button15")
                {
                    var c = (Button)control;
                    //c.FlatAppearance.
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }


                else if (control.Name == "buttonDRL")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }
            }

            if (currentHolder.listOfFrom.Name == "bp142")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите левый тумблер СЕТЬ-ОТКЛ в положение СЕТЬ";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на ДРЛ";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "drlStack")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Откройте БП-142";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 3

        public bool Quiz3IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerVoltage_drltop")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm3_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " на щите ЩП-5 автомат +27 В";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerVoltage_drltop")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button4")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "drlTop")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите на щите ЩП-5 автомат +27 В" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на верхнюю левую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 4

        public bool Quiz4IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerventilate_drltop")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm4_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат BЕНТИЛЯЦИЯ ИНДИКАТОРОВ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerventilate_drltop")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button4")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "drlTop")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите автомат ВЕНТИЛЯЦИЯ ИНДИКАТОРОВ" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на верхнюю левую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 5

        public bool Quiz5IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerventilate_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm5_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат ВЕНТИЛЯЦИЯ ПРАВОГО БОРТА";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerventilate_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите автомат ВЕНТИЛЯЦИЯ ПРАВОГО БОРТА" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 6

        public bool Quiz6IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerprl_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm6_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат АППАРАТУРА ПРЛ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerprl_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите автомат АППАРАТУРА ПРЛ" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 7

        public bool Quiz7IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerantenna_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm7_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат АНТЕННЫ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerantenna_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите автомат АНТЕННЫ" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 8

        public bool Quiz8IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerIndicate_drltop")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm8_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат ИНДИКАТОРЫ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerIndicate_drltop")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button4")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "drlTop")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите автомат ИНДИКАТОРЫ" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на верхнюю левую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 9

        public bool Quiz9IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbsf1_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm9_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер БСФ-1";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerbsf1_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер БСФ-1" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 10

        public bool Quiz10IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbsf2_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm10_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер БСФ-2";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerbsf2_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер БСФ-2" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 11

        public bool Quiz11IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbrn1_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm11_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер БРН-1";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerbrn1_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер БРН-1" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 12

        public bool Quiz12IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbrn2_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm12_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер БРН-2";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerbrn2_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер БРН-2" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 13

        public bool Quiz13IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerku_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm13_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер КУ";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerku_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер КУ" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 14

        public bool Quiz14IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbpr_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm14_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер БПР-Н";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerbpr_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер БПР-Н" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion

        #region Quiz 15

        public bool Quiz15IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbop_prlpwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }

        public void CheckForm15_PRLOn(Holder currentHolder, HelpForm helpForm)
        {
            var Controls = currentHolder.listOfControl;

            String txt = " автомат тумблер БОП";

            foreach (var control in Controls)
            {
                if (control.Name == "tumblerbop_prlpwr")
                {
                    var c = (Tumbler)control;
                    c.Highlight();
                }

                else if (control.Name == "button7")
                {
                    var c = (Button)control;
                    c.FlatAppearance.BorderSize = 3;
                    c.FlatAppearance.BorderColor = Color.Red;
                }

            }

            if (currentHolder.listOfFrom.Name == "prlPwr")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Включите тумблер БОП" + Environment.NewLine + "Положение вверху.";
                helpForm.GetHelp(t);
            }
            else if (currentHolder.listOfFrom.Name == "Form1")
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Нажмите на нижнюю правую часть щитка";
                helpForm.GetHelp(t);
            }
            else
            {
                TextForHelpForm t = new TextForHelpForm();
                t.NeedClick = "Включить " + txt;
                t.HelpText = "Вернитесь назад";
                helpForm.GetHelp(t);
            }
        }
        #endregion
    }
}
