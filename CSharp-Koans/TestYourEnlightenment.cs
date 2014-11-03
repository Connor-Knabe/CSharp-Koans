using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{
    [TestClass]
    public class UnitTest1{
        [TestMethod]
        public void TestMethod1() {
            MathKoans testMathKoans = new MathKoans();
            Assert.IsTrue(1 == testMathKoans.firstLast(2));


        }
    }
}
