using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{
    [TestClass]
    public class TestingMathKoans {
        MathKoans testMathKoans = new MathKoans();

        //----------START----------Tests for Sum problem
        [TestMethod]
        public void TestThatSumReturns4Given2and2() {
            Assert.IsTrue( 4 == testMathKoans.Sum(2,2));
        }

        [TestMethod]
        public void TestThatSumReturns6Given3and3() {

            Assert.IsTrue(6 == testMathKoans.Sum(3, 3));
        }




        //----------END----------Tests for Sum problem

    }
}
