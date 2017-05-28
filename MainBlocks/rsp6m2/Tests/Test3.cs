using rsp6m2.Controls;
using rsp6m2.EmulatorManager;
using rsp6m2.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace rsp6m2.Tests
{
    public class Test3
    {
        public static String TestName = "Включение и проверка" +
            Environment.NewLine + " работоспособности аппаратуры " +
            Environment.NewLine + "отображения ПРЛ";

        public static List<Quize> GetQuize()
        {
            List<Quize> list = new List<Quize>();

            #region Quize1
            Quize q = new Quize();
            q.ListOfConditions = Condition1;

            Dictionary<int, TextForHelpForm> helpDictionary = new Dictionary<int, TextForHelpForm>();
            TextForHelpForm t = new TextForHelpForm();


            String txt = "Включить тумблер" + Environment.NewLine +
                "Би-45";
            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БИ-45";
            t.NeedClick = txt;
            helpDictionary.Add(91, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на Индикатор";
            t.NeedClick =  txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блоки под столечницей индикатора ПРЛ";
            t.NeedClick = txt;
            helpDictionary.Add(9, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick =  txt;
            helpDictionary.Add(-1, t);


            List<string> cName = new List<string>();
            cName.Add("prlblock_bi45");
            cName.Add("UnderPRLblocks");
            cName.Add("buttonIKO");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize2
            q = new Quize();
            q.ListOfConditions = Condition2;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Включить тумблер" + Environment.NewLine +
                "БОИ";
            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БУО";
            t.NeedClick = txt;
            helpDictionary.Add(91, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на Индикатор";
            t.NeedClick = txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блоки под столечницей индикатора ПРЛ";
            t.NeedClick = txt;
            helpDictionary.Add(9, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("prlblock_buo");
            cName.Add("UnderPRLblocks");
            cName.Add("buttonIKO");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize3
            q = new Quize();
            q.ListOfConditions = Condition3;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Включить тумблер" + Environment.NewLine +
                "БОИ";
            t = new TextForHelpForm();
            t.HelpText = "Включите тумблер БОИ";
            t.NeedClick = txt;
            helpDictionary.Add(91, t);

            t = new TextForHelpForm();
            t.HelpText = "Нажмите на Индикатор";
            t.NeedClick = txt;
            helpDictionary.Add(0, t);

            t = new TextForHelpForm();
            t.HelpText = "Откройте блоки под столечницей индикатора ПРЛ";
            t.NeedClick = txt;
            helpDictionary.Add(9, t);

            t = new TextForHelpForm();
            t.HelpText = "Вернитесь назад";
            t.NeedClick = txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("prlblock_boi");
            cName.Add("UnderPRLblocks");
            cName.Add("buttonIKO");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            #region Quize4
            q = new Quize();
            q.ListOfConditions = Condition4;

            helpDictionary = new Dictionary<int, TextForHelpForm>();
            t = new TextForHelpForm();


            txt = "Индикатор ПРЛ включен." + Environment.NewLine +
                "Проверкой работы индикатора заключается в" + Environment.NewLine + 
                "визуальном наблюдении работы индикатора.";
            t = new TextForHelpForm();
            t.HelpText = txt;
            t.NeedClick = txt;
            helpDictionary.Add(9, t);

            //t = new TextForHelpForm();
            //t.HelpText = "Нажмите на Индикатор";
            //t.NeedClick = txt;
            //helpDictionary.Add(0, t);

            //t = new TextForHelpForm();
            //t.HelpText = "Откройте блоки под столечницей индикатора ПРЛ";
            //t.NeedClick = txt;
            //helpDictionary.Add(9, t);

            t = new TextForHelpForm();
            t.HelpText = txt;
            t.NeedClick = txt;
            helpDictionary.Add(-1, t);


            cName = new List<string>();
            cName.Add("buttonFinish");
            //cName.Add("UnderPRLblocks");
            //cName.Add("buttonIKO");

            q.ListOfHelp = helpDictionary;
            q.NameOfLightedControls = cName;

            list.Add(q);
            #endregion

            return list;
        }


        #region Quize1

        public static bool Condition1(Control c)
        {
            if (c.Name == "prlblock_bi45")
            {
                var t = (Tumbler2)c;
                if (t.CurrentTumblerPosition() == Position.Up)
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
            if (c.Name == "prlblock_buo")
            {
                var t = (Tumbler2)c;
                if (t.CurrentTumblerPosition() == Position.Up)
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
            if (c.Name == "prlblock_boi")
            {
                var t = (Tumbler2)c;
                if (t.CurrentTumblerPosition() == Position.Up)
                {
                    Console.WriteLine("Правильно нажал");
                    HelpClass.Helper.isPRLWork = true;
                    HelpClass.Helper.ChangeVisibleButtonFinish();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Quize4

        public static bool Condition4(Control c)
        {
            if (c.Name == "buttonFinish")
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
