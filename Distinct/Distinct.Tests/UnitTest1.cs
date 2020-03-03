using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Distinct.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SingleElement()
        {
            Assert.AreEqual(1, Program.solution(new int[] { 0 }));
        }

        [TestMethod]
        public void EmptyElement()
        {
            Assert.AreEqual(0, Program.solution(new int[] {}));
        }

        [TestMethod]
        public void LargeList()
        {
            Assert.AreEqual(3, Program.solution(new int[] { 2,1,1,2,3,1 }));
        }

        [TestMethod]
        public void NegativeList()
        {
            Assert.AreEqual(3, Program.solution(new int[] { -2, -1, -1, -2, -3, -1 }));
        }

        [TestMethod]
        public void Duplicates()
        {
            Assert.AreEqual(1, Program.solution(new int[] { 9,9,9,9,9,9,9 }));
        }


    }
}
