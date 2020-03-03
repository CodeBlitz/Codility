using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nesting.Tests
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void OneCharacter()
        {            
            Assert.AreEqual(0, Program.solution("("));
        }

        [TestMethod]
        public void OddCount()
        {
            Assert.AreEqual(0, Program.solution("(()"));
            Assert.AreEqual(0, Program.solution(")()"));            
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
            Assert.AreEqual(1, Program.solution("(()())"));            
        }

        [TestMethod]
        public void TwoAdjacent()
        {         
            Assert.AreEqual(1, Program.solution("()()"));         
        }


        [TestMethod]
        public void AllOneType()
        {
            Assert.AreEqual(1, Program.solution("((((()))))"));
        }

        [TestMethod]
        public void AllOpen()
        {
            string startBrackets = new String('(', 1000000);

            Assert.AreEqual(0, Program.solution(startBrackets));
        }

        [TestMethod]
        public void AllClosed()
        {
            string startBrackets = new String(')', 1000000);

            Assert.AreEqual(0, Program.solution(startBrackets));
        }


        [TestMethod]
        public void LargeNestedSingle()
        {
            string startBrackets = new String('(', 500000);
            string endBrackets = new String(')', 500000);

            Assert.AreEqual(1, Program.solution(startBrackets + endBrackets));
        }

    }

}
