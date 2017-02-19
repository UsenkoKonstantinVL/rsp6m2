using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using rsp6m2.Manager;
using rsp6m2.Managers;

namespace rsp6m2.EmulatorManager
{
    static public  class EmulatorManager
    {
        static List<Quize> Test;
        static int currentQuize;
        static string TestName = null;
        static bool withHelp = false;
        /// <summary>
        /// Инициализируем менеждер
        /// </summary>
        /// <param name="numTest"></param>
        /// <param name="withHelp"></param>
        public static void InitializeManager(int numTest, bool _withHelp)
        {
            Test = null;
            currentQuize = 0;
            //numTest = 1;

            var data =  Tests.TestFactory.GetTest(numTest);
            Test = data.list;
            TestName = data.testName;
            /*if (numTest == 0)
            {
                Test = Tests.Test1.GetQuize();
                TestName = Tests.Test1.TestName;
            }


            else 
            {
                Test = Tests.Test2.GetQuize();
                TestName = Tests.Test2.TestName;
            }*/

            withHelp = _withHelp;


            if(withHelp)
            {
                ManagerHelpForm.InitializeForm();
                ManagerHelpForm.SetHelp(Test[currentQuize].ListOfHelp);
            }

            ManagerForm1.InitializeForm();

        }


        static bool IsTestComplete = false;
        /// <summary>
        /// Вызывается при нажатии на контроллы типа кнопки для проверки на правильное нажатие
        /// </summary>
        /// <param name="c"></param>
        public static void CheckQuize(Control c)
        {
            if (Test[currentQuize].ListOfConditions(c) == true)
            {
                currentQuize++;
                if (withHelp && currentQuize < Test.Count)
                {
                    //QuizeIsDone(GetListOfLightedControls());
                    SendMassageThatQuizeIsDone();
                    ManagerHelpForm.SetHelp(Test[currentQuize].ListOfHelp);
                }
            }

            if (currentQuize == Test.Count)
            {
                {
                    SendMassageThatTestIsDone();
                    IsTestComplete = true;
                    TestComplete();
                }
            }
        }

        public static List<string> GetListOfLightedControls()
        {
            if(withHelp && Test != null && currentQuize < Test.Count)
            {
                return Test[currentQuize].NameOfLightedControls;
            }

            return new List<string>();
        }

        /// <summary>
        /// Отмена теста
        /// </summary>
        public static void TestCancel()
        {
            if(IsTestComplete == true)
            {
                TestComplete();
                IsTestComplete = false;
                return;
            }
            ManagerHelpForm.CloseHelp();
            Forms.CompleteForm f = new Forms.CompleteForm();
            f.GetName("Отмена теста: " + Environment.NewLine + "\"" +  TestName + "\"", "Отмена теста");
            f.ShowDialog();
            Managers.ManagerMainForm.FormShow();

            Test = null;
            currentQuize = 0;
            QuizeIsDone = null;
            TestIsDone = null;

            listQuizeIsDone = new List<EmulatorManagerHelp.quizeIsDone>();
            listTestIsDone = new List<EmulatorManagerHelp.testIzDone>();   
        }


        /// <summary>
        /// Завершение теста
        /// </summary>
        public static void TestComplete()
        {
            ManagerHelpForm.CloseHelp();
            Forms.CompleteForm f = new Forms.CompleteForm();
            f.GetName("Пройден тест: " + Environment.NewLine + "\"" + TestName + "\"", "Тест окончен");
            f.ShowDialog();
            Managers.ManagerMainForm.FormShow();

            Test = null;
            currentQuize = 0;
            QuizeIsDone = null;
            TestIsDone = null;

            listQuizeIsDone = new List<EmulatorManagerHelp.quizeIsDone>();
            listTestIsDone = new List<EmulatorManagerHelp.testIzDone>();
        }

        public static void SetListenerToQuizeIsDone(EmulatorManagerHelp.quizeIsDone q)
        {
            listQuizeIsDone.Add(q);
        }

        static private void SendMassageThatQuizeIsDone()
        {
            //QuizeIsDone(GetListOfLightedControls());
            foreach(EmulatorManagerHelp.quizeIsDone q in listQuizeIsDone)
            {
                q(GetListOfLightedControls());
            }

        }

        static public void DeleteListenerToQuizeIsDone(EmulatorManagerHelp.quizeIsDone q)
        {
            listQuizeIsDone.Remove(q);
        }

        static public void SetListenerTestIsDone(EmulatorManagerHelp.testIzDone t)
        {
            listTestIsDone.Add(t);
        }

        static public void DeleteListenerTestIsDone(EmulatorManagerHelp.testIzDone t)
        {
            listTestIsDone.Remove(t);
        }

        static private void SendMassageThatTestIsDone()
        {
            //QuizeIsDone(GetListOfLightedControls());
            if (listTestIsDone != null)
            {
                foreach (EmulatorManagerHelp.testIzDone q in listTestIsDone)
                {
                    q();
                }
            }

        }

        #region Delegate

        public static EmulatorManagerHelp.quizeIsDone QuizeIsDone;
        static List<EmulatorManagerHelp.quizeIsDone> listQuizeIsDone = new List<EmulatorManagerHelp.quizeIsDone>();
        public static EmulatorManagerHelp.testIzDone TestIsDone;
        private static List<EmulatorManagerHelp.testIzDone> listTestIsDone = new List<EmulatorManagerHelp.testIzDone>();

        #endregion
    }

    public class EmulatorManagerHelp
    {
        public delegate bool isQuizeDone(Control changedControl);
        public delegate void quizeIsDone(List<string> listLightedControls);
        public delegate void testIzDone();
    }

    public class Quize
    {
        public EmulatorManagerHelp.isQuizeDone ListOfConditions;
        public List<string> NameOfLightedControls;
        //public TextForHelpForm ListOfHelp;
        public Dictionary<int, TextForHelpForm> ListOfHelp;
    }
}
