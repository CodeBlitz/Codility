using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PassingCars.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Program.solution(new int[] { 0 }));


        }
    }
}
