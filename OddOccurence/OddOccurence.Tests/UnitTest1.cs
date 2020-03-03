using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddOccurence;


namespace OddOccurence.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleData()
        {
            Assert.AreEqual(7, Program.solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
        }


        [TestMethod]
        public void BigNumbers()
        {
            Assert.AreEqual(1000000001, Program.solution(new int[] { 1000000000, 1000000001, 1000000000, 900000000, 900000000, 77, 77 }));
        }

        [TestMethod]
        public void DuplicateOdds()
        {
            Assert.AreEqual(7, Program.solution(new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 5, 7, 33, 7, 5, 7, 33 }));
            Assert.AreEqual(1, Program.solution(new int[] { 8, 3, 9, 3, 9, 8, 1, 5, 1, 5, 1, 2, 2 }));
        }


        [TestMethod]
        public void StartWithOdd()
        {
            Assert.AreEqual(7, Program.solution(new int[] { 7, 3, 9, 3, 9, 9, 9 }));
        }

        [TestMethod]
        public void EndWithOdd()
        {
            Assert.AreEqual(1, Program.solution(new int[] { 8, 3, 9, 3, 9, 8, 1 }));
        }

        [TestMethod]
        public void SuperBigNumbers()
        {

            List<int> bigList = new List<int>();

            int counterValue = 2;
            int endValue = 99999;
            while (counterValue < endValue)
            {
                bigList.Add(counterValue);
                counterValue++;
            }

            // Adding the odd value we are looking for.
            bigList.Add(1);

            while (counterValue > 1)
            {
                bigList.Add(counterValue);
                counterValue--;
            }

            Assert.AreEqual(1, Program.solution(bigList.ToArray()));
        }

    }

    [TestClass]
    public class Solution2Tests
    {
        [TestMethod]
        public void SampleData()
        {
            Assert.AreEqual(7, Program.solution2(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
        }


        [TestMethod]
        public void BigNumbers()
        {
            Assert.AreEqual(1000000001, Program.solution2(new int[] { 1000000000, 1000000001, 1000000000, 900000000, 900000000, 77, 77 }));
        }

        [TestMethod]
        public void DuplicateOdds()
        {
            Assert.AreEqual(7, Program.solution2(new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 5, 7, 33, 7, 5, 7, 33 }));
            Assert.AreEqual(1, Program.solution2(new int[] { 8, 3, 9, 3, 9, 8, 1, 5, 1, 5, 1, 2, 2 }));
        }


        [TestMethod]
        public void StartWithOdd()
        {
            Assert.AreEqual(7, Program.solution2(new int[] { 7, 3, 9, 3, 9, 9, 9 }));
        }

        [TestMethod]
        public void EndWithOdd()
        {
            Assert.AreEqual(1, Program.solution2(new int[] { 8, 3, 9, 3, 9, 8, 1 }));
        }

        [TestMethod]
        public void SuperBigNumbers()
        {

            List<int> bigList = new List<int>();

            int counterValue = 2;
            int endValue = 999999;
            while (counterValue < endValue)
            {
                bigList.Add(counterValue);
                counterValue++;
            }

            // Adding the odd value we are looking for.
            bigList.Add(1);

            while (counterValue > 1)
            {
                bigList.Add(counterValue);
                counterValue--;
            }

            Assert.AreEqual(1, Program.solution2(bigList.ToArray()));
        }

    }

    [TestClass]
    public class Solution3Tests
    {
        [TestMethod]
        public void SampleData()
        {
            Assert.AreEqual(7, Program.solution3(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
        }


        [TestMethod]
        public void BigNumbers()
        {
            Assert.AreEqual(1000000, Program.solution3(new int[] { 1000000000, 1000000, 1000000000, 90000000, 90000000, 77, 77 }));
        }

        [TestMethod]
        public void DuplicateOdds()
        {
            Assert.AreEqual(7, Program.solution3(new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 5, 7, 33, 7, 5, 7, 33 }));
            Assert.AreEqual(1, Program.solution3(new int[] { 8, 3, 9, 3, 9, 8, 1, 5, 1, 5, 1, 2, 2 }));
        }


        [TestMethod]
        public void StartWithOdd()
        {
            Assert.AreEqual(7, Program.solution3(new int[] { 7, 3, 9, 3, 9, 9, 9 }));
        }

        [TestMethod]
        public void EndWithOdd()
        {
            Assert.AreEqual(1, Program.solution3(new int[] { 8, 3, 9, 3, 9, 8, 1 }));
        }

        [TestMethod]
        public void SingleOdd()
        {
            Assert.AreEqual(7, Program.solution3(new int[] { 7 }));
        }

        [TestMethod]
        public void SuperBigNumbers()
        {

            List<int> bigList = new List<int>();

            int counterValue = 2;
            int endValue = 999999;
            while (counterValue < endValue)
            {
                bigList.Add(counterValue);
                counterValue++;
            }

            // Adding the odd value we are looking for.
            bigList.Add(1);

            while (counterValue > 1)
            {
                bigList.Add(counterValue);
                counterValue--;
            }

            Assert.AreEqual(1, Program.solution3(bigList.ToArray()));
        }

    }



    [TestClass]
    public class Solution4Tests
    {
        [TestMethod]
        public void SampleData()
        {
            Assert.AreEqual(7, Program.solution4(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
        }


        [TestMethod]
        public void BigNumbers()
        {
            Assert.AreEqual(1000000, Program.solution4(new int[] { 1000000000, 1000000, 1000000000, 90000000, 90000000, 77, 77 }));
        }

        [TestMethod]
        public void DuplicateOdds()
        {
            Assert.AreEqual(7, Program.solution4(new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 5, 7, 33, 7, 5, 7, 33 }));
            Assert.AreEqual(1, Program.solution4(new int[] { 8, 3, 9, 3, 9, 8, 1, 5, 1, 5, 1, 2, 2 }));
        }


        [TestMethod]
        public void StartWithOdd()
        {
            Assert.AreEqual(7, Program.solution4(new int[] { 7, 3, 9, 3, 9, 9, 9 }));
        }

        [TestMethod]
        public void EndWithOdd()
        {
            Assert.AreEqual(1, Program.solution4(new int[] { 8, 3, 9, 3, 9, 8, 1 }));
        }

        [TestMethod]
        public void SingleOdd()
        {
            Assert.AreEqual(7, Program.solution4(new int[] { 7 }));
        }

        [TestMethod]
        public void SuperBigNumbers()
        {

            List<int> bigList = new List<int>();

            int counterValue = 2;
            int endValue = 999999;
            while (counterValue < endValue)
            {
                bigList.Add(counterValue);
                counterValue++;
            }

            // Adding the odd value we are looking for.
            bigList.Add(1);

            while (counterValue > 1)
            {
                bigList.Add(counterValue);
                counterValue--;
            }

            Assert.AreEqual(1, Program.solution4(bigList.ToArray()));
        }

    }
}
