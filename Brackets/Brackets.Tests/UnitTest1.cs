using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Brackets.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OneCharacter()
        {
            Assert.AreEqual(0, Program.solution("{"));
            Assert.AreEqual(0, Program.solution("]"));
            Assert.AreEqual(0, Program.solution("["));
            Assert.AreEqual(0, Program.solution("("));
        }

        [TestMethod]
        public void OddCount()
        {
            Assert.AreEqual(0, Program.solution("{[]"));
            Assert.AreEqual(0, Program.solution("[(]"));
            Assert.AreEqual(0, Program.solution("[{}[{]]"));
            Assert.AreEqual(0, Program.solution("((((())))"));
        }

        [TestMethod]
        public void Empty()
        {
            Assert.AreEqual(1, Program.solution(String.Empty));            
        }

        [TestMethod]
        public void TwoNested()
        {
            Assert.AreEqual(1, Program.solution("[()[]]"));
            Assert.AreEqual(1, Program.solution("{()()}"));
            Assert.AreEqual(1, Program.solution("([]{})"));
        }

        [TestMethod]
        public void TwoAdjacent()
        {
            Assert.AreEqual(1, Program.solution("()[]"));
            Assert.AreEqual(1, Program.solution("()()"));
            Assert.AreEqual(1, Program.solution("[]{}"));
        }


        [TestMethod]
        public void AllOneType()
        {
            Assert.AreEqual(1, Program.solution("((((()))))"));
            Assert.AreEqual(1, Program.solution("[[[]]]"));
            Assert.AreEqual(1, Program.solution("{}"));
        }

    }
}
