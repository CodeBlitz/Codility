using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MissingInteger;

namespace MissingInteger.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            Assert.AreEqual(5, Program.solution(new int[] { 1, 3, 6, 4, 1, 2 }));
            Assert.AreEqual(1, Program.solution(new int[] { 0 }));
            Assert.AreEqual(2, Program.solution(new int[] { 1 }));
            Assert.AreEqual(2, Program.solution(new int[] { 1, 0 }));
        }

        [TestMethod]
        public void NegativesOnly()
        {
            Assert.AreEqual(1, Program.solution(new int[] { -1, -3, -6, -4, -1, -2 }));
            Assert.AreEqual(1, Program.solution(new int[] { 0, 0, 0, }));
            Assert.AreEqual(1, Program.solution(new int[] { -1 }));
        }

        [TestMethod]
        public void MultipleSpans()
        {
            Assert.AreEqual(4, Program.solution(new int[] { -1, -3, -6, 1, 2, 3, 6, 7, 8, 11, 12, 13 }));            
        }

        [TestMethod]
        public void FloatingSpan()
        {            
            Assert.AreEqual(1, Program.solution(new int[] { 13, 12, 11, 10 }));            
        }

        [TestMethod]
        public void StartAtTwo()
        {            
            Assert.AreEqual(1, Program.solution(new int[] { 2, 3, 4, 5, 6, 7, 8 }));
        }



        [TestMethod]
        public void LargePositive()
        {
            int[] largeList = new int[100000];

            for (int i = 0; i < 50000; i++)
            {
                largeList[i] = -1000000 + i;
            }

            for (int i = 50000; i < 100000; i++)
            {
                largeList[i] = -70000 + i;
            }

            Assert.AreEqual(30000, Program.solution(largeList));
        }
    }
}
