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

            }
            else if(numOfTest == 1)
            {
                t.list = Tests.Test3.GetQuize();
            }
            else
            {
                t.list = Tests.Test2.GetQuize();
                t.testName = Tests.Test2.TestName;
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
