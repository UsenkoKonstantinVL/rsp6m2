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
    public static class Test1
    {
        public static String TestName = "Включение аппаратуры ПРЛ";

        public static List<Quize> GetQuize()
        {
            List<Quize> list = new List<Quize>();

            #region Quize1
            Quize q = new Quize();
            q.ListOfConditions = Condition1;

            Dictionary<int, TextForHelpForm> helpDictionary = new Dictionary<int, TextForHelpForm>();
            TextForHelpForm t = new TextForHelpForm();
            

            String txt = " на БП-142 (стойка СВП-01)" + Environment.NewLine + "тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            t = new TextForHelpForm();
            t.HelpText = "Включите правый тумблер СЕТЬ-ОТКЛ в положение СЕТЬ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(101, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-142";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            List<string> cName = new List<string>();
            cName.Add("tumblerPowerPrl");
            cName.Add("button15_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize2
            q = new Quize();
            q.ListOfConditions = Quiz2IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " на БП-142 (стойка СВП-01) тумблеры СЕТЬ-ОТКЛ в положение СЕТЬ";

            t = new TextForHelpForm();
            t.HelpText = "Включите правый тумблер СЕТЬ-ОТКЛ в положение СЕТЬ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(101, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-142";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerPowerDrl");
            cName.Add("button15_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize3
            q = new Quize();
            q.ListOfConditions = Quiz3IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " на щите ЩП-5 автомат +27 В";

            t = new TextForHelpForm();
            t.HelpText = "Включите на щите ЩП-5 автомат +27 В" + Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(23, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на верхнюю левую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerVoltage_drltop");
            cName.Add("button4");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize4
            q = new Quize();
            q.ListOfConditions = Quiz4IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат BЕНТИЛЯЦИЯ ИНДИКАТОРОВ";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат ВЕНТИЛЯЦИЯ ИНДИКАТОРОВ" +
                    Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(23, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на верхнюю левую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerventilate_drltop");
            cName.Add("button4");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize5
            q = new Quize();
            q.ListOfConditions = Quiz5IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат ВЕНТИЛЯЦИЯ ПРАВОГО БОРТА";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат ВЕНТИЛЯЦИЯ ПРАВОГО БОРТА" +
                    Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerventilate_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize6
            q = new Quize();
            q.ListOfConditions = Quiz6IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат АППАРАТУРА ПРЛ";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат АППАРАТУРА ПРЛ" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerprl_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize7
            q = new Quize();
            q.ListOfConditions = Quiz7IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат АНТЕННЫ";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат АНТЕННЫ" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerantenna_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize8
            q = new Quize();
            q.ListOfConditions = Quiz8IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат ИНДИКАТОРЫ";

            t = new TextForHelpForm();
            t.HelpText = "Включите автомат ИНДИКАТОРЫ" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(23, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на верхнюю левую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerIndicate_drltop");
            cName.Add("button4");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            

            #region Quize9
            q = new Quize();
            q.ListOfConditions = Quiz9IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БСФ-1";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БСФ-1" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbsf1_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize10
            q = new Quize();
            q.ListOfConditions = Quiz10IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БСФ-2";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БСФ-2" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbsf2_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize11
            q = new Quize();
            q.ListOfConditions = Quiz11IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БРН-1";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БРН-1" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbrn1_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize12
            q = new Quize();
            q.ListOfConditions = Quiz12IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БРН-2";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БРН-2" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbrn2_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize13
            q = new Quize();
            q.ListOfConditions = Quiz13IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер КУ";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер КУ" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerku_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize14
            q = new Quize();
            q.ListOfConditions = Quiz14IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БПР-Н";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БПР-Н" +
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbpr_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize15
            q = new Quize();
            q.ListOfConditions = Quiz15IsNotDone_PRLOn;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = " автомат тумблер БОП";

            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БОП" + 
                Environment.NewLine + "Положение вверху.";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(21, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижнюю правую часть щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbop_prlpwr");
            cName.Add("button7");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            return list;
        }

        #region Quize1

        public static bool Condition1(Control c)
        {
            if (c.Name == "tumblerPowerPrl")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }
            return false;
        }

        #endregion

        #region Quize2

        public static bool Quiz2IsNotDone_PRLOn(Control clickedControl)
        {
            if (clickedControl.Name == "tumblerPowerDrl")
            {
                Console.WriteLine("Правильно нажал");
                return true;
            }


            return false;
        }
        #endregion

        #region Quiz 3

        public static bool Quiz3IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm3_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz4IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm4_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz5IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm5_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz6IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm6_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz7IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm7_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static void CheckForm8_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz9IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm9_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz10IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm10_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz11IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm11_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz12IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm12_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz13IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm13_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz14IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm14_PRLOn(Holder currentHolder, HelpForm helpForm)
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

        public static bool Quiz15IsNotDone_PRLOn(Control clickedControl)
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

        public static void CheckForm15_PRLOn(Holder currentHolder, HelpForm helpForm)
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
