using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TapeEquilibrium;

namespace TapeEquilibrium.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeavyLeftSide()
        {
            Assert.AreEqual(10, TapeEquilibrium.Program.solution(new int[] { -10000, 10000, -20000, 19990, 100, 200, -300 }));

        }

        [TestMethod]
        public void TowEqualElements()
        {
            Assert.AreEqual(0, TapeEquilibrium.Program.solution(new int[] { 1, 1 }));

        }

        [TestMethod]
        public void TowElements()
        {
            Assert.AreEqual(2, TapeEquilibrium.Program.solution(new int[] { -1, 1 }));

        }


        [TestMethod]
        public void TowZeros()
        {
            Assert.AreEqual(0, TapeEquilibrium.Program.solution(new int[] { 0, 0 }));

        }

        [TestMethod]
        public void TowExtreme()
        {
            Assert.AreEqual(2000, TapeEquilibrium.Program.solution(new int[] { -1000, 1000 }));

        }

        [TestMethod]
        public void TwoExtremeRange()
        {
            Assert.AreEqual(1000, TapeEquilibrium.Program.solution(new int[] { 1000, 2000, -1000, -2001 }));

        }


        [TestMethod]
        public void AllZeros()
        {
            Assert.AreEqual(0, TapeEquilibrium.Program.solution(new int[] { 0, 0, 0, 0, 0, 0 }));

        }


        [TestMethod]
        public void AllNegative()
        {
            Assert.AreEqual(189, TapeEquilibrium.Program.solution(new int[] { -1, -10, -100, -300 }));

        }

        [TestMethod]
        public void AllPositive()
        {
            Assert.AreEqual(189, TapeEquilibrium.Program.solution(new int[] { 1, 10, 100, 300 }));

        }

        [TestMethod]
        public void LargeListMixed()
        {
            int insertValue = -1000;
            int maxValue = 1000;
            int[] largeList = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                if (insertValue >= maxValue)
                {
                    insertValue = -1000;
                }
                largeList[i] = insertValue;
                insertValue++;
            }

            Assert.AreEqual(0, TapeEquilibrium.Program.solution(largeList));

        }
    }
}
