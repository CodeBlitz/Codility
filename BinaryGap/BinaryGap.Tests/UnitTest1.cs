using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryGap;

namespace BinaryGap.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(2, BinaryGap.Program.solution(9));
            Assert.AreEqual(4, BinaryGap.Program.solution(529));
            Assert.AreEqual(1, BinaryGap.Program.solution(20));
            Assert.AreEqual(0, BinaryGap.Program.solution(15));
            Assert.AreEqual(0, BinaryGap.Program.solution(32));
            Assert.AreEqual(5, BinaryGap.Program.solution(1041));

        }

        [TestMethod]
        public void LargeNumbers()
        {
            Assert.AreEqual(0, BinaryGap.Program.solution(2147483647));
            Assert.AreEqual(0, BinaryGap.Program.solution(2147483646));
        }
    }
}
