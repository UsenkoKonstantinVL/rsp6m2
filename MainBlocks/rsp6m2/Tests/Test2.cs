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

    }
}
