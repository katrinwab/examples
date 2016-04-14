using System;
using examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, Program.Area(5, 3, 4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                Program.Area(10, 3, 4);
                Assert.Fail("test2 - 10 3 4. An exception should have been thrown");
            }
            catch (WrongLengthException ex)
            {
                Assert.AreEqual("Неверная длина сторон", ex.Message);
            }
            catch (Exception ex)
            {
                Assert.Fail("Unexpected exception");
            }
        }
    }
}
