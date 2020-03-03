using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PermCheck.Tests
{
    [TestClass]
    public class TrueTests
    {
        [TestMethod]
        public void SingleOneTest()
        {
            Assert.AreEqual(1, PermCheck.Program.solution(new int[] { 1 }));            
        }

        [TestMethod]
        public void TwoValues()
        {
            Assert.AreEqual(1, PermCheck.Program.solution(new int[] { 1, 2 }));            
        }

        [TestMethod]
        public void FullList()
        {
            int[] fullList = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                // Fill list with numbers starting from 1.
                fullList[i] = i + 1;
            }

            Assert.AreEqual(1, PermCheck.Program.solution(fullList));
        }
    }

    [TestClass]
    public class FalseTests
    {
        [TestMethod]
        public void TwoValues()
        {
            Assert.AreEqual(0, PermCheck.Program.solution(new int[] { 1, 3 }));
            Assert.AreEqual(0, PermCheck.Program.solution(new int[] { 2, 3, 4 }));
            Assert.AreEqual(0, PermCheck.Program.solution(new int[] { 99, 3 }));
            Assert.AreEqual(0, PermCheck.Program.solution(new int[] { 1, 1000000000 }));


        }

        [TestMethod]
        public void TwoSections()
        {
            Assert.AreEqual(0, PermCheck.Program.solution(new int[] { 1, 2, 3, 4, 5, 999999999, 1000000000 }));
            Assert.AreEqual(0, PermCheck.Program.solution(new int[] { 1, 2, 3, 99, 100, 101, 102 }));
        }

        [TestMethod]
        public void FullList()
        {

            int[] fullList = new int[100000];

            for (int i = 0; i < 100000 -1; i++)
            {
                // Fill list with numbers starting from 1.
                if (i != 999841)
                {
                    fullList[i] = 100001;
                }
                else
                {
                    fullList[i] = i + 1;
                }                
            }

            Assert.AreEqual(0, PermCheck.Program.solution(fullList));            
        }

        [TestMethod]
        public void FullListStartAtTwo()
        {
            int[] fullList = new int[100000];

            for (int i = 0; i < 100000 - 1; i++)
            {                                
                fullList[i] = i + 2;                
            }

            Assert.AreEqual(0, PermCheck.Program.solution(fullList));
        }
    }
}


