using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxSliceSum.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleData()
        {
            Assert.AreEqual(5, Program.solution(new int[] { 3, 2, -6, 4, 0 }));
        }


        [TestMethod]
        public void SingleValue()
        {
            Assert.AreEqual(0, Program.solution(new int[] { 0 }));
            Assert.AreEqual(1, Program.solution(new int[] { 1 }));
            Assert.AreEqual(-1, Program.solution(new int[] { -1 }));
        }


        [TestMethod]
        public void OneBigValue()
        {
            Assert.AreEqual(100004, Program.solution(new int[] { -3, 2, -4, 4, 0, 100000, -6, 5, -8, 4 }));
        }


        [TestMethod]
        public void AllNegatives()
        {
            Assert.AreEqual(0, Program.solution(new int[] { -3, -2, -4, -4, -10, -100000, -6, -5, -8, -4, 0 }));
            Assert.AreEqual(0, Program.solution(new int[] { -1000000, -1000000, -1000000 }));
        }
    }
}
