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
        public static String TestName = "Включение и проверка" + Environment.NewLine + "работоспособности приемопередатчиков" +
            Environment.NewLine + " ППП-1, ППП-II";

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
            t.HelpText = "Установите переключатель РАБОТА-КОНТРОЛЬ \n в положение «РАБОТА»";
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
            
             q = new Quize();
            q.ListOfConditions = Condition2;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
             t = new TextForHelpForm();


             txt = "Переключатель в положение" + Environment.NewLine +
                " -125В";
            t = new TextForHelpForm();
            t.HelpText = "Установите переключатель в положение -125В";
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
            t.HelpText = "Установите переключатель в положение 150В";
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
            t.HelpText = "Установите переключатель в положение 250В";
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
            t.HelpText = "Установите переключатель в положение ТОК ПР УМН" + Environment.NewLine + "Показания прибора должны быть в пределах \n зеленого и красного (для ОУ) секторов";
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
            t.HelpText = "Установите переключатель в положение ТОК II УМН" + Environment.NewLine +
               "Показания прибора должны быть в пределах зеленого \n и красного (для ОУ) секторов";
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
            t.HelpText = "Установите переключатель в положение ТОК III УМН" + Environment.NewLine +
               "Показания прибора должны быть в пределах зеленого и \n красного (для ОУ) секторов";
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
            t.HelpText = "Установите переключатель в положение КОНТРОЛЬ ОУ" + Environment.NewLine +
               "Показания прибора должны быть в пределах зеленого \n и красного (для ОУ) секторов"; ;
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
            t.HelpText = "Установите переключатель в положение +125 BI";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
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
            t.HelpText = "Установите переключатель в положение +125 BII";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
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
            t.HelpText = "Установите переключатель в положение +250 В";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
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
            t.HelpText = "Установите переключатель в положение -100 В";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
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
            t.HelpText = "Установите переключатель в положение УСТ 0" + Environment.NewLine + "Показания должны быть близкие к 0";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
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
            t.HelpText = "Установите переключатель в положение УСТ НАПР" + Environment.NewLine + "Показания должны быть близкие к 0";
            t.NeedClick = txt;
            helpDictionary.Add(428, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
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
            t.HelpText = "Установите переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine + "в положение КР1" + Environment.NewLine +
                "Показания прибора должны быть" + Environment.NewLine + "в пределах красного сектора";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПР-021";
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
            t.HelpText = "Установите переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine + "в положение КР2" + Environment.NewLine +
                "Показания прибора должны быть" + Environment.NewLine + "в пределах красного сектора";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПР-021";
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
            t.HelpText = "Установите переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine + "в положение КР3" + Environment.NewLine +
                "Показания прибора должны быть" + Environment.NewLine + "в пределах красного сектора";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПР-021";
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
            t.HelpText = "Установите переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine + "в положение КР4" + Environment.NewLine +
                "Показания прибора должны быть" + Environment.NewLine + "в пределах красного сектора";
            t.NeedClick = txt;
            helpDictionary.Add(421, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПР-021";
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
            
            //#region Quize18
            //q = new Quize();
            //q.ListOfConditions = Condition18;

            //helpDictionary = new Dictionary<int, TextForHelpForm>();
            //t = new TextForHelpForm();


            //txt = "Установить переключатель КОНТРОЛЬ ТОКОВ" + Environment.NewLine +
            //    "поочередно в положения КР4";
            //t = new TextForHelpForm();
            //t.HelpText = "Показания прибора должны быть" + Environment.NewLine
            //     + "в пределах красного сектора.";
            //t.NeedClick = txt;
            //helpDictionary.Add(421, t);

            //t = new TextForHelpForm();
            //t.HelpText = "Нажмите на ПРЛ";
            //t.NeedClick = "Включить " + txt;
            //helpDictionary.Add(0, t);

            //t = new TextForHelpForm();
            //t.HelpText = "Откройте БГ-021";
            //t.NeedClick = txt;
            //helpDictionary.Add(4, t);

            //t = new TextForHelpForm();
            //t.HelpText = "Вернитесь назад";
            //t.NeedClick = "Включить " + txt;
            //helpDictionary.Add(-1, t);


            //cName = new List<string>();
            //cName.Add("roundTumbler_bpr021");
            //cName.Add("button21_prl");
            //cName.Add("buttonPRL");

            //q.ListOfHelp = helpDictionary;
            //q.NameOfLightedControls = cName;

            //list.Add(q);
            //#endregion

            #region Quize19
            q = new Quize();
            q.ListOfConditions = Condition19;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверка правильности работы" + Environment.NewLine
                 + "Должна гореть лампочка: БЛОКИРОВКА ЗАМКНУТА." + Environment.NewLine +
                 "Показания прибора НАПРЯЖЕНИЕ НАКАЛА ГЕНЕРАТОРА." + Environment.NewLine +
                 "Oно должно быть от 14 до 16 В";
            t = new TextForHelpForm();
            t.HelpText = "Проверка правильности работы" + Environment.NewLine
                 + "Должна гореть лампочка: БЛОКИРОВКА ЗАМКНУТА." + Environment.NewLine +
                 "Показания прибора НАПРЯЖЕНИЕ НАКАЛА ГЕНЕРАТОРА." + Environment.NewLine +
                 "Oно должно быть от 14 до 16 В";
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
            //cName.Add("roundTumbler_bpr021");
            cName.Add("button16_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize20
            q = new Quize();
            q.ListOfConditions = Condition20;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На передней панели БВМ-011" + Environment.NewLine + 
                " нажать кнопку ИЗМЕРЕНИЕ";
            t = new TextForHelpForm();
            t.HelpText = "Нажмите кнопку ИЗМЕРЕНИЕ";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("bigbutton1_bvm011_1");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion
            
            #region Quize21
            q = new Quize();
            q.ListOfConditions = Condition21;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора -50 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора -50 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ" + Environment.NewLine + "Для контроля показания прибора -50В";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_2");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize22
            q = new Quize();
            q.ListOfConditions = Condition22;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора -150 В";
            t = new TextForHelpForm();
            t.HelpText =  "Проконтролировать показания прибора -150 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_2");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize23
            q = new Quize();
            q.ListOfConditions = Condition23;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора -300 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора -300 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_2");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion


            #region Quize24
            q = new Quize();
            q.ListOfConditions = Condition24;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора -600 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора -600 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_2");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            

            #region Quize25
            q = new Quize();
            q.ListOfConditions = Condition25;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора 600 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора 600 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_1");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize26
            q = new Quize();
            q.ListOfConditions = Condition26;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора 1900 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора 1900 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_1");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion       

            #region Quize27
            q = new Quize();
            q.ListOfConditions = Condition27;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БУВ-021" + Environment.NewLine +
                " включить тумблер ВКЛ ВН";
            t = new TextForHelpForm();
            t.HelpText = "На БУВ-021 включить тумблер ВКЛ ВН";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

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
            cName.Add("tumbler_buc021_1");
            cName.Add("button16_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

			/*
            #region Quize28
            q = new Quize();
            q.ListOfConditions = Condition28;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На передней правой панели БВМ-011" + Environment.NewLine +
                " нажать кнопку ИЗМЕРЕНИЕ";
            t = new TextForHelpForm();
            t.HelpText = "Нажать кнопку ИЗМЕРЕНИЕ";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("bigbutton1_bvm011_2");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion
			*/

            #region Quize29
            q = new Quize();
            q.ListOfConditions = Condition29;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора 600 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора 600 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_1");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize30
            q = new Quize();
            q.ListOfConditions = Condition30;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БВМ-011" + Environment.NewLine +
                " проконтролировать показания прибора 1900 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать показания прибора 1900 В";
            t.NeedClick = txt;
            helpDictionary.Add(413, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БВМ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bvm011_1");
            cName.Add("button13_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            

            #region Quize31
            q = new Quize();
            q.ListOfConditions = Condition31;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На  панели БУВ-021" + Environment.NewLine +
                " проконтролировать показания прибора ВЫСОКОЕ НАПРЯЖЕНИЕ";
            t = new TextForHelpForm();
            t.HelpText = "Тумблером БОЛЬШЕ-МЕНЬШЕ на БУВ-021 осуществить" + 
                Environment.NewLine + "подъем высокого напряжения  " +
                Environment.NewLine + "до появления показаний прибора ВЫСОКОЕ НАПРЯЖЕНИЕ +26 мА";
            t.NeedClick = txt;
            helpDictionary.Add(416, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БГВ-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumbler_buv021_1");
            cName.Add("button16_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion


            #region Quize32
            q = new Quize();
            q.ListOfConditions = Condition32;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Переключение тумблера " + Environment.NewLine +
                " в блоке БОП";
            t = new TextForHelpForm();
            t.HelpText = "Тумблер ВЫКЛ БОН поставить в положение «БОП» " +
                Environment.NewLine + "проконтролировать загорание лампочки НОРМА";
            t.NeedClick = txt;
            helpDictionary.Add(401, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БОП";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("tumblerbop_1");
            cName.Add("button1_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize33
            q = new Quize();
            q.ListOfConditions = Condition33;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На блоках БСФ первого и второго " + Environment.NewLine +
                " комплекта по загоранию светодиодов проконтролировать" + Environment.NewLine +
                " наличие питающих напряжений -12,6 В, +5 В, +24 В, +48 В";
            t = new TextForHelpForm();
            t.HelpText = "";
            //    Environment.NewLine + "проконтролировать загорание лампочки НОРМА";
            t.NeedClick = txt;
            helpDictionary.Add(402, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БСФ";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            //cName.Add("tumblerbop_1");
            cName.Add("button2_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            //list = new List<Quize>();

            #region Quize34
            q = new Quize();
            q.ListOfConditions = Condition34;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "На блоке БПРН-021 проверить наличие" +
                Environment.NewLine + "питающих напряжений -125 В, +150 В, +250 В " +
                Environment.NewLine + "и загорание сигнальных ламп КАНАЛ, ГОТОВ РАБОТА ";
            t = new TextForHelpForm();
            t.HelpText = "На блоке БПРН-021 проверить наличие" +
                Environment.NewLine + "питающих напряжений -125 В, +150 В, +250 В " +
                Environment.NewLine + "и загорание сигнальных ламп КАНАЛ, ГОТОВ РАБОТА ";
            t.NeedClick = txt;
            helpDictionary.Add(410, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БПРН-021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            //cName.Add("tumblerbop_1");
            cName.Add("button10_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize35
            q = new Quize();
            q.ListOfConditions = Condition35;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверка работы гетеродина";
            t = new TextForHelpForm();
            t.HelpText = "Переключатель контрольного прибора поставить" +
                Environment.NewLine + " в положения: «Канал-1» ";
            t.NeedClick = txt;
            helpDictionary.Add(410, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БПРН 021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bprn021_2");
            cName.Add("button10_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize36
            q = new Quize();
            q.ListOfConditions = Condition36;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверка работы гетеродина";
            t = new TextForHelpForm();
            t.HelpText = "Переключатель контрольного прибора поставить" +
                Environment.NewLine + " в положения: «Канал-2» ";
            t.NeedClick = txt;
            helpDictionary.Add(410, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БПРН 021";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bprn021_2");
            cName.Add("button10_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize37
            q = new Quize();
            q.ListOfConditions = Condition37;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Контроль работоспособность компенсирующего устройства ПРЛ";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать наличие" +
                Environment.NewLine + " питающих напряжений -100 В I";
            t.NeedClick = txt;
            helpDictionary.Add(401, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БП 127";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bp127");
            cName.Add("button17_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize38
            q = new Quize();
            q.ListOfConditions = Condition38;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Контроль работоспособность компенсирующего устройства ПРЛ";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать наличие" +
                Environment.NewLine + " питающих напряжений +150 В I";
            t.NeedClick = txt;
            helpDictionary.Add(401, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БП 127";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bp127");
            cName.Add("button17_prl");
            cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize39
            q = new Quize();
            q.ListOfConditions = Condition39;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Контроль работоспособность компенсирующего устройства ПРЛ";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать наличие" +
                Environment.NewLine + " питающих напряжений +250 В I";
            t.NeedClick = txt;
            helpDictionary.Add(401, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на ПРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блок БП 127";
            t.NeedClick = txt;
            helpDictionary.Add(4, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("roundTrumbler_bp127");
            cName.Add("button17_prl");
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
                if (t.CurrentIndex == 4)
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
                    EmulatorManager.GlobalManager.Buv021Voltmeter3 = 35;
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

        #region Quize20
        public static bool Condition20(Control c)
        {
            if (c.Name == "bigbutton1_bvm011_1")
            {
                return true;

            }
            return false;
        }

        #endregion

        #region Quize21
        public static bool Condition21(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 0)
                {
                    Console.WriteLine("Правильно нажал");
                    EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize22
        public static bool Condition22(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion
    
        #region Quize23
        public static bool Condition23(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_2")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 2)
                {
                    Console.WriteLine("Правильно нажал");
                    EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize24
        public static bool Condition24(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_2")
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

        #region Quize25
        public static bool Condition25(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize26
        public static bool Condition26(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_1")
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


        #region Quize27
        public static bool Condition27(Control c)
        {
            if (c.Name == "tumbler_buc021_1")
            {
                var t = (Tumbler)c;
                if (t.CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    //EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize28
        public static bool Condition28(Control c)
        {
            if (c.Name == "bigbutton1_bvm011_2")
            {
                
                return true;
                
            }
            return false;
        }

        #endregion

        #region Quize29
        public static bool Condition29(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 1)
                {
                    Console.WriteLine("Правильно нажал");
                    //EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize30
        public static bool Condition30(Control c)
        {
            if (c.Name == "roundTrumbler_bvm011_1")
            {
                var t = (RoundTrumbler)c;
                if (t.CurrentIndex == 3)
                {
                    Console.WriteLine("Правильно нажал");
                    //EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize31
        public static bool Condition31(Control c)
        {
            if (c.Name == "tumbler_buv021_1")
            {
                var t = (tumbler3)c;
                if (t.Position == 0)
                {
                    Console.WriteLine("Правильно нажал");
                    //EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize32
        public static bool Condition32(Control c)
        {
            if (c.Name == "tumblerbop_1")
            {
                var t = (Tumbler2)c;
                if (t.CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    //EmulatorManager.GlobalManager.IsLampBuv021Light = true;
                    GlobalManager.BSFisOn1Complect = true;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Quize33
        public static bool Condition33(Control c)
        {
            if (c.Name == "button2_prl")
            {
                GlobalManager.BPRN021FirstOn = true;
                return true;
               
            }
            return false;
        }

        #endregion

        #region Quize34
        public static bool Condition34(Control c)
        {
            if (c.Name == "button10_prl")
            {

                return true;

            }
            return false;
        }

        #endregion

        #region Quize35
        public static bool Condition35(Control c)
        {
            if (c.Name == "roundTrumbler_bprn021_2")
            {
                var b = (RoundTrumbler)c;

                if (b.CurrentIndex == 3)
                {

                    return true;
                }

            }
            return false;
        }

        #endregion

        #region Quize36
        public static bool Condition36(Control c)
        {
            if (c.Name == "roundTrumbler_bprn021_2")
            {
                var b = (RoundTrumbler)c;

                if (b.CurrentIndex == 4)
                {

                    return true;
                }

            }
            return false;
        }

        #endregion

        #region Quize37
        public static bool Condition37(Control c)
        {
            if (c.Name == "roundTrumbler_bp127")
            {
                var b = (RoundTrumbler)c;

                if (b.CurrentIndex == 1)
                {

                    return true;
                }

            }
            return false;
        }

        #endregion

        #region Quize38
        public static bool Condition38(Control c)
        {
            if (c.Name == "roundTrumbler_bp127")
            {
                var b = (RoundTrumbler)c;

                if (b.CurrentIndex == 3)
                {

                    return true;
                }

            }
            return false;
        }

        #endregion

        #region Quize39
        public static bool Condition39(Control c)
        {
            if (c.Name == "roundTrumbler_bp127")
            {
                var b = (RoundTrumbler)c;

                if (b.CurrentIndex == 5)
                {

                    return true;
                }

            }
            return false;
        }

        #endregion

    }
}
