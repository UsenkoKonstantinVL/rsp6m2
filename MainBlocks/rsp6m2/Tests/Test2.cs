using rsp6m2.Controls;
using rsp6m2.EmulatorManager;
using rsp6m2.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Tests
{
    public static class Test2
    {
        public static String TestName = "Включение и проверка работоспособности" + 
            Environment.NewLine +  " приемопередатчиков ППП-1, ППП-II";

        public static List<Quize> GetQuize()
        {
            List<Quize> list = new List<Quize>();

            #region Quize1
            Quize q = new Quize();
            q.ListOfConditions = Condition1;

            Dictionary<int, TextForHelpForm> helpDictionary = new Dictionary<int, TextForHelpForm>();
            TextForHelpForm t = new TextForHelpForm();


            String txt = "Переключатель РАБОТА-КОНТРОЛЬ" + Environment.NewLine +
                " установить в положение «РАБОТА»";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(406, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БУ-011";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            List<string> cName = new List<string>();
            cName.Add("tumbler_bu011_1");
            cName.Add("button6_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion


            #region Quize2
            /*
             q = new Quize();
            q.ListOfConditions = Condition2;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
             t = new TextForHelpForm();


             txt = "Переключатель в положение" + Environment.NewLine +
                " -125В";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_1");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize3
            q = new Quize();
            q.ListOfConditions = Condition3;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "150В";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_1");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize4
            q = new Quize();
            q.ListOfConditions = Condition4;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "250В";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_1");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize5
            q = new Quize();
            q.ListOfConditions = Condition5;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "ТОК ПР УМН" + Environment.NewLine +
               "Показания прибора должны быть " + Environment.NewLine  + 
               "в пределах зеленого и красного (для ОУ) секторов";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_2");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize6
            q = new Quize();
            q.ListOfConditions = Condition6;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "ТОК II УМН" + Environment.NewLine +
               "Показания прибора должны быть " + Environment.NewLine +
               "в пределах зеленого и красного (для ОУ) секторов";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_2");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize7
            q = new Quize();
            q.ListOfConditions = Condition7;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "ТОК III УМН" + Environment.NewLine +
               "Показания прибора должны быть " + Environment.NewLine +
               "в пределах зеленого и красного (для ОУ) секторов";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_2");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize8
            q = new Quize();
            q.ListOfConditions = Condition8;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "КОНТРОЛЬ ОУ" + Environment.NewLine +
               "Показания прибора должны быть " + Environment.NewLine +
               "в пределах зеленого и красного (для ОУ) секторов";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(424, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bg021_2");
            cName.Add("button24_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize9
            q = new Quize();
            q.ListOfConditions = Condition9;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "+125 BI";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bpch_1");
            cName.Add("button28_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize10
            q = new Quize();
            q.ListOfConditions = Condition10;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "+125 BII";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bpch_1");
            cName.Add("button28_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize11
            q = new Quize();
            q.ListOfConditions = Condition11;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "+250 В";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bpch_1");
            cName.Add("button28_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize12
            q = new Quize();
            q.ListOfConditions = Condition12;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "-100 В";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bpch_1");
            cName.Add("button28_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize13
            q = new Quize();
            q.ListOfConditions = Condition13;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "УСТ 0, " + Environment.NewLine + "показания должны быть " + 
               Environment.NewLine + " близкие к 0";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bpch_2");
            cName.Add("button28_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize14
            q = new Quize();
            q.ListOfConditions = Condition14;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключатель в положение" + Environment.NewLine +
               "УСТ НАПР, " + Environment.NewLine + "показания должны быть " +
               Environment.NewLine + " близкие к 0";
            t = new TextForHelpForm();
            t.HelpText = "";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bpch_2");
            cName.Add("button28_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize15
            q = new Quize();
            q.ListOfConditions = Condition15;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Установить переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine + 
                "поочередно в положения КР1";
            t = new TextForHelpForm();
            t.HelpText = "Показания прибора должны быть" + Environment.NewLine
                 + "в пределах красного сектора.";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTumbler_bpr021");
            cName.Add("button21_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize16
            q = new Quize();
            q.ListOfConditions = Condition16;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Установить переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine +
                "поочередно в положения КР2";
            t = new TextForHelpForm();
            t.HelpText = "Показания прибора должны быть" + Environment.NewLine
                 + "в пределах красного сектора.";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTumbler_bpr021");
            cName.Add("button21_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize17
            q = new Quize();
            q.ListOfConditions = Condition17;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Установить переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine +
                "поочередно в положения КР3";
            t = new TextForHelpForm();
            t.HelpText = "Показания прибора должны быть" + Environment.NewLine 
                 + "в пределах красного сектора.";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTumbler_bpr021");
            cName.Add("button21_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize18
            q = new Quize();
            q.ListOfConditions = Condition18;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Установить переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine +
                "поочередно в положения КР4";
            t = new TextForHelpForm();
            t.HelpText = "Показания прибора должны быть" + Environment.NewLine
                 + "в пределах красного сектора.";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTumbler_bpr021");
            cName.Add("button21_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);*/
            #endregion

            #region Quize18
            q = new Quize();
            q.ListOfConditions = Condition18;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Установить переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine +
                "поочередно в положения КР4";
            t = new TextForHelpForm();
            t.HelpText = "Показания прибора должны быть" + Environment.NewLine
                 + "в пределах красного сектора.";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTumbler_bpr021");
            cName.Add("button21_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize19
            q = new Quize();
            q.ListOfConditions = Condition19;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверка правильности работы" + Environment.NewLine
                 + "Должна гореть лампочка: БЛОКИРОВКА ЗАМКНУТА";
            t = new TextForHelpForm();
            t.HelpText = "Показания прибора должны быть" + Environment.NewLine
                 + "в пределах красного сектора.";
            t.NeedClick = txt;
            helpDictionary.Add(416, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ"; 
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БУВ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTumbler_bpr021");
            cName.Add("button21_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            return list;
        }


        #region Quize1

        public static bool Condition1(Control c)
        {
            if (c.Name == "tumbler_bu011_1")
            {
                var t = (tumbler3)c;
                if (t.Position == 0)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize2

        public static bool Condition2(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 0)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize3

        public static bool Condition3(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize4

        public static bool Condition4(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize5

        public static bool Condition5(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 0)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize6

        public static bool Condition6(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize7

        public static bool Condition7(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize8

        public static bool Condition8(Control c)
        {
            if (c.Name == "roundTrumbler_bg021_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 3)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize9

        public static bool Condition9(Control c)
        {
            if (c.Name == "roundTrumbler_bpch_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize10

        public static bool Condition10(Control c)
        {
            if (c.Name == "roundTrumbler_bpch_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize11

        public static bool Condition11(Control c)
        {
            if (c.Name == "roundTrumbler_bpch_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 3)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize12

        public static bool Condition12(Control c)
        {
            if (c.Name == "roundTrumbler_bpch_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 3)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize13
        public static bool Condition13(Control c)
        {
            if (c.Name == "roundTrumbler_bpch_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize14
        public static bool Condition14(Control c)
        {
            if (c.Name == "roundTrumbler_bpch_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize15
        public static bool Condition15(Control c)
        {
            if (c.Name == "roundTumbler_bpr021")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 0)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize16
        public static bool Condition16(Control c)
        {
            if (c.Name == "roundTumbler_bpr021")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize17
        public static bool Condition17(Control c)
        {
            if (c.Name == "roundTumbler_bpr021")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize18
        public static bool Condition18(Control c)
        {
            if (c.Name == "roundTumbler_bpr021")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 3)
                {
                    Console.WriteLine("Правильно нажал");
                    EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize19
        public static bool Condition19(Control c)
        {
            if (c.Name == "button16_prl")
            {
                return true;
                /*var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 3)
                {
                    Console.WriteLine("Правильно нажал");
                    EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }*/
            }
            return false;
        }

        #endregion

    }
}
