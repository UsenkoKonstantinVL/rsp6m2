using rsp6m2.EmulatorManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace rsp6m2.Tests
{
    class TestFactory
    {
        static public TestData GetTest(int numOfTest)
        {
            TestData t = new TestData();
            if (numOfTest == 0)
            {
                t.list = Tests.Test1.GetQuize();
                t.testName = Tests.Test1.TestName;
            }
            else if (numOfTest == 3)
            {
                t.list = Tests.TestDRL1.GetQuize();
                t.testName = Tests.TestDRL1.TestName;
            }
            else if(numOfTest == 1)
            {
                t.list = Tests.Test3.GetQuize();
                t.testName = Test3.TestName;
            }
            else if(numOfTest == 4)
            {
                t.list = Tests.TestDRLIko.GetQuize();
                t.testName = TestDRLIko.TestName;
            }
            else if (numOfTest == 2)
            {
                t.list = Tests.Test2.GetQuize();
                t.testName = Test2.TestName;
            }
            else
            {
                t.list = Tests.TestDRL3.GetQuize();
                t.testName = Tests.TestDRL3.TestName;
            }
            

            return t;
        }
    }

    public class TestData
    {
        public List<Quize> list = new List<Quize>();
        public String testName = "";
    }
}
