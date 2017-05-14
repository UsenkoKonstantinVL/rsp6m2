using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using rsp6m2.EmulatorManager;
using rsp6m2.Manager;
using rsp6m2.Controls;
using rsp6m2.Forms;
using System.Drawing;

namespace rsp6m2.Tests
{
    public static class TestDRL1
    {
        static String TestName = "Включение аппаратуры ДРЛ";

        public static List<Quize> GetQuize()
        {
            List<Quize> list = new List<Quize>();

            #region Quize1
            Quize q = new Quize();
            q.ListOfConditions = QuizeDone1;

            Dictionary<int, TextForHelpForm> helpDictionary = new Dictionary<int, TextForHelpForm>();
            TextForHelpForm t = new TextForHelpForm();


            var txt = " на БП-142 (стойка СВП-01)" + Environment.NewLine + "тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            t = new TextForHelpForm();
            t.HelpText = "Включите ВЕНТИЛЯЦИЮ ИНДИКАТОРОВ";
            t.NeedClick = "";
            helpDictionary.Add(23, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на верхний блок ДРЛ";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            List<string> cName = new List<string>();
            cName.Add("button4");
            cName.Add("tumblerventilate_drltop");
            
            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize2
            q = new Quize();
            q.ListOfConditions = QuizeDone2;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            //var txt = " на БП-142 (стойка СВП-01)" + Environment.NewLine + "тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            t = new TextForHelpForm();
            t.HelpText = "Включите ВЕНТИЛЯЦИЮ ЛЕВОГО БОРТА";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижний блок ДРЛ";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("button6");
            cName.Add("tumblerventilate_drlPwr");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize3
            q = new Quize();
            q.ListOfConditions = QuizeDone3;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            //var txt = " на БП-142 (стойка СВП-01)" + Environment.NewLine + "тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            t = new TextForHelpForm();
            t.HelpText = "Нажмите ВКЛ.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижний блок ДРЛ";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("button6");
            cName.Add("buttnoVkl_drlPwr");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize4
            q = new Quize();
            q.ListOfConditions = QuizeDone4;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            //var txt = " на БП-142 (стойка СВП-01)" + Environment.NewLine + "тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            t = new TextForHelpForm();
            t.HelpText = "Нажмите ВКЛ.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижний блок ДРЛ";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("button6");
            cName.Add("tumblerprl_drlPwr");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize5
            q = new Quize();
            q.ListOfConditions = QuizeDone5;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат АНТЕННЫ";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат АНТЕННЫ" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю левую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "";
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerantenna_drlPwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize6
            q = new Quize();
            q.ListOfConditions = Quiz8IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат ИНДИКАТОРЫ";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат ИНДИКАТОРЫ" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(23, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на верхнюю левую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "";
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerIndicate_drltop");
            cName.Add("button4");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize7
            q = new Quize();
            q.ListOfConditions = QuizeDone7;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-I";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БОСТ-I" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerBost1_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize8
            q = new Quize();
            q.ListOfConditions = QuizeDone8;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-II";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БОСТ-II" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerBost2_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize9
            q = new Quize();
            q.ListOfConditions = QuizeDone9;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-II";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БРН-I" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbrn1_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize10
            q = new Quize();
            q.ListOfConditions = QuizeDone10;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-II";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БРН-II" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbrn2_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize11
            q = new Quize();
            q.ListOfConditions = QuizeDone11;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-II";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер КУ" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerku_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize12
            q = new Quize();
            q.ListOfConditions = QuizeDone12;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-II";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер НПО-I" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerNpo1_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize13
            q = new Quize();
            q.ListOfConditions = QuizeDone13;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОСТ-II";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер НПО-II" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "";
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "";
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerNpo2_drlPwr");
            cName.Add("button6");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            return list;
        }


        #region Quiz 1

        public static bool QuizeDone1(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerventilate_drltop")
            {
                return true;
            }


            return false;
        }


        #endregion

        #region Quiz 2

        public static bool QuizeDone2(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerventilate_drlPwr")
            {
                return true;
            }


            return false;
        }


        #endregion

        #region Quiz 3

        public static bool QuizeDone3(Control clickedControl)
        {
            if (clickedControl.Name == "buttnoVkl_drlPwr")
            {
                return true;
            }


            return false;
        }


        #endregion

        #region Quiz 4

        public static bool QuizeDone4(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerprl_drlPwr")
            {
                return true;
            }


            return false;
        }


        #endregion

        #region Quiz 5

        public static bool QuizeDone5(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerantenna_drlPwr")
            {
                return true;
            }


            return false;
        }


        #endregion

        #region Quiz 6

        public static bool Quiz8IsNotDone_PRLOn(Control clickedControl)
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
        #endregion

        #region Quiz 7

        public static bool QuizeDone7(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerBost1_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion

        #region Quiz 8

        public static bool QuizeDone8(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerBost2_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion

        #region Quiz 9

        public static bool QuizeDone9(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbrn1_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion

        #region Quiz 10

        public static bool QuizeDone10(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerbrn2_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion

        #region Quiz 11

        public static bool QuizeDone11(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerku_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion

        #region Quiz 12

        public static bool QuizeDone12(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerNpo1_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion

        #region Quiz 13

        public static bool QuizeDone13(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerNpo2_drlPwr")
            {
                if (((Tumbler)clickedControl).CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }


            return false;
        }
        #endregion
    }
}
