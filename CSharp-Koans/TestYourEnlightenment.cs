using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{
    [TestClass]
    public class TestingMathKoans {
        MathKoans testMathKoans = new MathKoans();


        //----------START----------Tests for Sum problem
        [TestMethod]
        public void TestThatSumReturns4Given_2and2() {
            Assert.IsTrue( 4 == testMathKoans.Sum(2,2));
        }
        [TestMethod]
        public void TestThatSumReturns6Given_3and3() {
            Assert.IsTrue(6 == testMathKoans.Sum(3, 3));
        }
        [TestMethod]
        public void TestThatSumReturns0Given_0and0() {
            Assert.IsTrue(0 == testMathKoans.Sum(0, 0));
        }
        //----------END----------Tests for Sum problem
    }

    [TestClass]
    public class TestingStringKoans {
        StringKoans testStringKoans = new StringKoans();


        //----------START----------Tests for StringAdd problem
        [TestMethod]
        public void TestThatStringAddReturnsHelloWorldGiven_HelloandWorld() {
            Assert.IsTrue("HelloWorld" == testStringKoans.StringAdd("Hello", "World"));
        }
        [TestMethod]
        public void TestThatStringAddReturnsHelloSpaceWorldGiven_HelloSpaceandWorld() {
            Assert.IsTrue("Hello World" == testStringKoans.StringAdd("Hello ", "World"));
        }
        //----------END----------Tests for StringAdd problem

        //----------START----------Tests for WordReverse problem
        [TestMethod]
        public void TestReverseWordReturnsHelloWorldGiven_olleH_Space_dlroW() {
            Assert.IsTrue("Hello World" == testStringKoans.WordReverse("olleH dlroW"));
        }

        //----------END----------Tests for WordReverse problem



    } 

}
