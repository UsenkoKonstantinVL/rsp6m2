using System;
using System.Collections.Generic;
using System.Windows.Forms;
using rsp6m2.Controls;
using rsp6m2.EmulatorManager;
using rsp6m2.Manager;

namespace rsp6m2.Tests
{
    public static class TestDRL3
    {
        public static String TestName = "Включение и проверка" + Environment.NewLine + "работоспособности" +
            Environment.NewLine + "приемопередатчиков" +
            Environment.NewLine + "ППД-1, ППД-II";

        public static List<Quize> GetQuize()
        {
            List<Quize> list = new List<Quize>();

            var otherForms = new TextForHelpForm();
            otherForms.HelpText = "Вернитесь назад";
            otherForms.NeedClick = "";

            #region Quize1
            Quize q = new Quize();
            q.ListOfConditions = Condition1;

            Dictionary<int, TextForHelpForm> helpDictionary = new Dictionary<int, TextForHelpForm>();
            TextForHelpForm t = new TextForHelpForm();


            String txt = "Переключатель РАБОТА-КОНТРОЛЬ" + Environment.NewLine +
                " установить в положение «РАБОТА»";
            t = new TextForHelpForm();
            t.HelpText = "Включить тумблер НПО-II";
            t.NeedClick = txt;
            helpDictionary.Add(24, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на нижний левый блок щитка";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);

            //t = new TextForHelpForm();
            //t.HelpText = "Откройте БУ-011";
            //t.NeedClick = txt;
            //helpDictionary.Add(4, t);

            helpDictionary.Add(-1, otherForms);


            List<string> cName = new List<string>();
            cName.Add("tumblerNpo2_drlPwr");
            cName.Add("button6");
            /// cName.Add("buttonPRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize2
            q = new Quize();
            q.ListOfConditions = Condition2;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проконтролировать  наличие питающего напряжения 125 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать  наличие питающего напряжения 125 В";
            t.NeedClick = txt;
            helpDictionary.Add(102, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте Б-213";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp213");
            cName.Add("button2_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize3
            q = new Quize();
            q.ListOfConditions = Condition3;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проконтролировать  наличие питающего напряжения 125 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать  наличие питающего напряжения +150 (4) В";
            t.NeedClick = txt;
            helpDictionary.Add(102, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте Б-213";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp213");
            cName.Add("button2_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize4
            q = new Quize();
            q.ListOfConditions = Condition4;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проконтролировать  наличие питающего напряжения +150 (3) В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать  наличие питающего напряжения 125 В";
            t.NeedClick = txt;
            helpDictionary.Add(102, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте Б-213";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp213");
            cName.Add("button2_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize5
            q = new Quize();
            q.ListOfConditions = Condition5;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();

            txt = "Проконтролировать  наличие питающего напряжения 125 В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать  наличие питающего напряжения 250 (2) В";
            t.NeedClick = txt;
            helpDictionary.Add(102, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте Б-213";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp213");
            cName.Add("button2_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize6
            q = new Quize();
            q.ListOfConditions = Condition6;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проконтролировать  наличие питающего напряжения 250 (1) В";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать  наличие питающего напряжения 250 (1) В";
            t.NeedClick = txt;
            helpDictionary.Add(102, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте Б-213";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp213");
            cName.Add("button2_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize7
            q = new Quize();
            q.ListOfConditions = Condition7;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте включение светодиодов";
            t.NeedClick = txt;
            helpDictionary.Add(107, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БОСТ\nПроверьте включение светодиодов";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            //cName.Add("roundTrumbler_bp213");
            cName.Add("button7_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            

            #region Quize8
            q = new Quize();
            q.ListOfConditions = Condition8;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения -100 В1";
            t.NeedClick = txt;
            helpDictionary.Add(117, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-127";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp127_drl");
            cName.Add("button17_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize9
            q = new Quize();
            q.ListOfConditions = Condition9;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения -100 В2";
            t.NeedClick = txt;
            helpDictionary.Add(117, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-127";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp127_drl");
            cName.Add("button17_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize10
            q = new Quize();
            q.ListOfConditions = Condition10;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +150 В1";
            t.NeedClick = txt;
            helpDictionary.Add(117, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-127";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp127_drl");
            cName.Add("button17_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize11
            q = new Quize();
            q.ListOfConditions = Condition11;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +150 В2";
            t.NeedClick = txt;
            helpDictionary.Add(117, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-127";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp127_drl");
            cName.Add("button17_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize12
            q = new Quize();
            q.ListOfConditions = Condition12;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +250 В1";
            t.NeedClick = txt;
            helpDictionary.Add(117, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-127";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp127_drl");
            cName.Add("button17_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize13
            q = new Quize();
            q.ListOfConditions = Condition13;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +250 В2";
            t.NeedClick = txt;
            helpDictionary.Add(117, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-127";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp127_drl");
            cName.Add("button17_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize14
            q = new Quize();
            q.ListOfConditions = Condition14;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения -100 ВI";
            t.NeedClick = txt;
            helpDictionary.Add(116, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-138";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp138");
            cName.Add("button16_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize15
            q = new Quize();
            q.ListOfConditions = Condition15;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +125 ВI";
            t.NeedClick = txt;
            helpDictionary.Add(116, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-138";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp138");
            cName.Add("button16_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize16
            q = new Quize();
            q.ListOfConditions = Condition16;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +150 ВI";
            t.NeedClick = txt;
            helpDictionary.Add(116, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-138";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp138");
            cName.Add("button16_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize17
            q = new Quize();
            q.ListOfConditions = Condition17;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +250 ВI";
            t.NeedClick = txt;
            helpDictionary.Add(116, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БП-138";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp138");
            cName.Add("button16_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

           

            #region Quize18
            q = new Quize();
            q.ListOfConditions = Condition18;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения -105 В";
            t.NeedClick = txt;
            helpDictionary.Add(119, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-1";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp011sm1");
            cName.Add("button19_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize19
            q = new Quize();
            q.ListOfConditions = Condition19;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +120 В";
            t.NeedClick = txt;
            helpDictionary.Add(119, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-1";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp011sm1");
            cName.Add("button19_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize20
            q = new Quize();
            q.ListOfConditions = Condition20;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения -105 В";
            t.NeedClick = txt;
            helpDictionary.Add(122, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-2";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp011sm2");
            cName.Add("button22_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize21
            q = new Quize();
            q.ListOfConditions = Condition21;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения +125 В";
            t.NeedClick = txt;
            helpDictionary.Add(122, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-2";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp011sm2");
            cName.Add("button22_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            //list = new List<Quize>();

            #region Quize22
            q = new Quize();
            q.ListOfConditions = Condition22;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения ТОК ДЕТ I\nТок должен находится в секторе от 80 до 200";
            t.NeedClick = txt;
            helpDictionary.Add(119, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-1";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp011sm1");
            cName.Add("button19_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize23
            q = new Quize();
            q.ListOfConditions = Condition23;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения ТОК ДЕТ II\nТок должен находится в секторе от 80 до 200";
            t.NeedClick = txt;
            helpDictionary.Add(119, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-1";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bp011sm1");
            cName.Add("button19_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize24
            q = new Quize();
            q.ListOfConditions = Condition24;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения ТОК ДЕТ I\nТок должен находится в секторе от 8 до 20";
            t.NeedClick = txt;
            helpDictionary.Add(120, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bpchs");
            cName.Add("button20_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize25
            q = new Quize();
            q.ListOfConditions = Condition25;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения ТОК ДЕТ II\nТок должен находится в секторе от 8 до 20";
            t.NeedClick = txt;
            helpDictionary.Add(120, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bpchs");
            cName.Add("button20_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize26
            q = new Quize();
            q.ListOfConditions = Condition26;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения \"0 обр. св. -\"\nТок должен находится близко к 0";
            t.NeedClick = txt;
            helpDictionary.Add(120, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bpchs");
            cName.Add("button20_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize27
            q = new Quize();
            q.ListOfConditions = Condition27;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проверьте наличие напряжения \"Упр. Напр.\"\nТок должен находится около 20 А";
            t.NeedClick = txt;
            helpDictionary.Add(120, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПЧ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            cName.Add("roundTrumbler_bpchs");
            cName.Add("button20_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize28
            q = new Quize();
            q.ListOfConditions = Condition28;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать горение транспорантов ГОТОВ и РАБОТА";
            t.NeedClick = txt;
            helpDictionary.Add(119, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-1\nПроконтролировать горение транспорантов ГОТОВ и РАБОТА";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            //cName.Add("roundTrumbler_bp011sm2");
            cName.Add("button19_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize29
            q = new Quize();
            q.ListOfConditions = Condition29;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Проверьте включение светодиодов";
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать горение транспорантов ГОТОВ и РАБОТА\nЗакройте блок";
            t.NeedClick = txt;
            helpDictionary.Add(119, t);
            
            t = new TextForHelpForm();
            t.HelpText = "Проконтролировать горение транспорантов ГОТОВ и РАБОТА";
            t.NeedClick = txt;
            helpDictionary.Add(122, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте БПр-2\nПроконтролировать горение транспорантов ГОТОВ и РАБОТА";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(1, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте ДРЛ";
            t.NeedClick = "Включить " + txt;
            helpDictionary.Add(0, t);


            helpDictionary.Add(-1, otherForms);

            cName = new List<string>();
            //cName.Add("roundTrumbler_bp011sm2");
            cName.Add("button22_drl");
            cName.Add("buttonDRL");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            return list;
        }


        #region Quize1
        public static bool Condition1(Control c)
        {
            if (c.Name == "tumblerNpo2_drlPwr")
            {
                var tumb = c as Tumbler;
                if(tumb.CurrentTumblerPosition() == Position.Up) return true;
            }
            return false;
        }

        #endregion

        #region Quize2
        public static bool Condition2(Control c)
        {
            if (c.Name == "roundTrumbler_bp213")
            {
                var tumb = c as RoundTrumbler;
                if (tumb.CurrentIndex == 1) return true;
            }
            return false;
        }

        #endregion

        #region Quize3
        public static bool Condition3(Control c)
        {
            if (c.Name == "roundTrumbler_bp213")
            {
                var tumb = c as RoundTrumbler;
                if (tumb.CurrentIndex == 2) return true;
            }
            return false;
        }

        #endregion

        #region Quize4
        public static bool Condition4(Control c)
        {
            if (c.Name == "roundTrumbler_bp213")
            {
                var tumb = c as RoundTrumbler;
                if (tumb.CurrentIndex == 3) return true;
            }
            return false;
        }

        #endregion

        #region Quize5
        public static bool Condition5(Control c)
        {
            if (c.Name == "roundTrumbler_bp213")
            {
                var tumb = c as RoundTrumbler;
                if (tumb.CurrentIndex == 4) return true;
            }
            return false;
        }

        #endregion

        #region Quize6
        public static bool Condition6(Control c)
        {
            if (c.Name == "roundTrumbler_bp213")
            {
                var tumb = c as RoundTrumbler;
                if (tumb.CurrentIndex == 5)
                {
                    HelpClass.Helper.bostLightOn = true;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize7
        public static bool Condition7(Control c)
        {
            if(c.Name != "light1_drl")
            {
                return false;
            }
            if(c is Light)
            //if (c.Name == "button7_drl")
            {
                var l = c as Light;
                if(l.isLight()) return true;
            }
            return false;
        }

        #endregion

        #region Quize8
        public static bool Condition8(Control c)
        {
            if (c.Name == "roundTrumbler_bp127_drl")
            {
                var rt = c as RoundTrumbler;
                if(rt.CurrentIndex == 1) return true;
                return true;
            }
            return false;
        }

        #endregion

        #region Quize9
        public static bool Condition9(Control c)
        {
            if (c.Name == "roundTrumbler_bp127_drl")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 2) return true;
                return true;
            }
            return false;
        }

        #endregion

        #region Quize10
        public static bool Condition10(Control c)
        {
            if (c.Name == "roundTrumbler_bp127_drl")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 3) return true;
                return true;
            }
            return false;
        }

        #endregion

        #region Quize11
        public static bool Condition11(Control c)
        {
            if (c.Name == "roundTrumbler_bp127_drl")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 4) return true;
                return true;
            }
            return false;
        }

        #endregion

        #region Quize12
        public static bool Condition12(Control c)
        {
            if (c.Name == "roundTrumbler_bp127_drl")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 5) return true;
                return true;
            }
            return false;
        }

        #endregion

        #region Quize13
        public static bool Condition13(Control c)
        {
            if (c.Name == "roundTrumbler_bp127_drl")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 6) {
                    HelpClass.Helper.isReady = true;
                    return true; }
                return true;
            }
            return false;
        }

        #endregion

        #region Quize14
        public static bool Condition14(Control c)
        {
            if (c.Name == "roundTrumbler_bp138")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 0) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize15
        public static bool Condition15(Control c)
        {
            if (c.Name == "roundTrumbler_bp138")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 1) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize16
        public static bool Condition16(Control c)
        {
            if (c.Name == "roundTrumbler_bp138")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 2) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize17
        public static bool Condition17(Control c)
        {
            if (c.Name == "roundTrumbler_bp138")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 3) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize18
        public static bool Condition18(Control c)
        {
            if (c.Name == "roundTrumbler_bp011sm1")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 3) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize19
        public static bool Condition19(Control c)
        {
            if (c.Name == "roundTrumbler_bp011sm1")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 4) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize20
        public static bool Condition20(Control c)
        {
            if (c.Name == "roundTrumbler_bp011sm2")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 3) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize21
        public static bool Condition21(Control c)
        {
            if (c.Name == "roundTrumbler_bp011sm2")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 4) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize22
        public static bool Condition22(Control c)
        {
            if (c.Name == "roundTrumbler_bp011sm1")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 1) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize23
        public static bool Condition23(Control c)
        {
            if (c.Name == "roundTrumbler_bp011sm1")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 2) return true;
                //return true;
            }
            return false;
        }
        #endregion

        #region Quize24
        public static bool Condition24(Control c)
        {
            if (c.Name == "roundTrumbler_bpchs")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 4) return true;
                //return true;
            }
            return false;
        }
        #endregion

        #region Quize25
        public static bool Condition25(Control c)
        {
            if (c.Name == "roundTrumbler_bpchs")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 5) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize26
        public static bool Condition26(Control c)
        {
            if (c.Name == "roundTrumbler_bpchs")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 1) return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize27
        public static bool Condition27(Control c)
        {
            if (c.Name == "roundTrumbler_bpchs")
            {
                var rt = c as RoundTrumbler;
                if (rt.CurrentIndex == 3)
                {
                    HelpClass.Helper.isBPRReady = true;
                    return true; }
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize28
        public static bool Condition28(Control c)
        {
            if (c.Name == "button19_drl")
            {
                return true;
                //return true;
            }
            return false;
        }

        #endregion

        #region Quize29
        public static bool Condition29(Control c)
        {
            if (c.Name == "button22_drl")
            {
                return true;
                //return true;
            }
            return false;
        }

        #endregion


    }
}
