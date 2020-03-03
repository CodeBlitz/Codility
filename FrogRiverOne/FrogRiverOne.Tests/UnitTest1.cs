using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrogRiverOne.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, FrogRiverOne.Program.solution(5, new int[] { 1,3,1,4,2,3,5,4 }));
        }

        [TestMethod]
        public void ShortPath()
        {
            Assert.AreEqual(0, FrogRiverOne.Program.solution(1, new int[] { 1 }));
        }

        
        [TestMethod]
        public void SingleLeaf()
        {
            Assert.AreEqual(-1, FrogRiverOne.Program.solution(5, new int[] { 2 }));
        }


        [TestMethod]
        public void NoPathForward()
        {
            Assert.AreEqual(-1, FrogRiverOne.Program.solution(5, new int[] { 1,2,3,4,4,3,2,1,2,3,4,2,1,1,2 }));
        }


        [TestMethod]
        public void PerfectPath()
        {
            Assert.AreEqual(7, FrogRiverOne.Program.solution(8, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }



        [TestMethod]
        public void MaximumLeavesCrossed()
        {
            int[] leaves = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                leaves[i] = i + 1;
            }

            Assert.AreEqual(99999, FrogRiverOne.Program.solution(100000, leaves));
        }

        [TestMethod]
        public void FirstLeafMissingMaximum()
        {
            int[] leaves = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                leaves[i] = i + 2;
            }

            Assert.AreEqual(-1, FrogRiverOne.Program.solution(100001, leaves));
        }
    }
}
