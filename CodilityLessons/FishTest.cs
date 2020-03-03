using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityLessons
{
    [TestClass]
    public class FishTests
    {
        [TestMethod]
        public void SampleData()
        {
            Assert.AreEqual(2, Fish.Program.solution(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }));
        }


        [TestMethod]
        public void BigDownStreamFish()
        {
            Assert.AreEqual(1, Fish.Program.solution(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 0, 0, 0, 0 }));
        }

        [TestMethod]
        public void BigUpStreamFish()
        {
            Assert.AreEqual(1, Fish.Program.solution(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 1, 1, 1, 0 }));
        }

        [TestMethod]
        public void BigMiddleFish()
        {
            Assert.AreEqual(3, Fish.Program.solution(new int[] { 1, 2, 5, 4, 3 }, new int[] { 0, 0, 1, 0, 0 }));
        }

        [TestMethod]
        public void TwoSchools()
        {
            Assert.AreEqual(6, Fish.Program.solution(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 0, 0, 0, 1, 1, 1 }));
        }
    }
}
