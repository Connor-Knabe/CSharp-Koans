using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{
    [TestClass]
    public class TestingMathKoans {
        MathKoans testMathKoans = new MathKoans();


        //----------START----------Tests for Sum problem
        [TestMethod]
        public void TestThatSumReturns_4_Given_2and2() {
            Assert.IsTrue( 4 == testMathKoans.Sum(2,2));
        }
        [TestMethod]
        public void TestThatSumReturns_6_Given_3and3() {
            Assert.IsTrue(6 == testMathKoans.Sum(3, 3));
        }
        [TestMethod]
        public void TestThatSumReturns_0_Given_0and0() {
            Assert.IsTrue(0 == testMathKoans.Sum(0, 0));
        }

    }

    [TestClass]
    public class TestingStringKoans {
        StringKoans testStringKoans = new StringKoans();


        //----------START----------Tests for StringAdd problem
        [TestMethod]
        public void TestThatStringAddReturns_HelloWorld_Given_HelloandWorld() {
            Assert.IsTrue("HelloWorld" == testStringKoans.StringAdd("Hello", "World"));
        }
        [TestMethod]
        public void TestThatStringAddReturns_HelloSpaceWorld_Given_HelloSpaceandWorld() {
            Assert.IsTrue("Hello World" == testStringKoans.StringAdd("Hello ", "World"));
        }

        //----------START----------Tests for WordReverse problem
        [TestMethod]
        public void TestReverseWordReturns_HelloWorld_Given_olleH_Space_dlroW() {
            Assert.IsTrue("Hello World" == testStringKoans.WordReverse("olleH dlroW"));
        }

        //----------START----------Tests for FirstLast problem
        [TestMethod]
        public void TestFirstLastReturns_as_Given_apples() {
            Assert.IsTrue("as" == testStringKoans.FirstLast("apples"));
        }


    } 

}
