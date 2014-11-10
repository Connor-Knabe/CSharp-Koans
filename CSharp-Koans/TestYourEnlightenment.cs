using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{

    //-------------------------START-------------------------------------------------Tests for Math Koans

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

        //----------START----------Tests for Pythagorean problem
        [TestMethod]
        public void TestThatPythagoreanReturns_5_Given_4and3() {
            Assert.IsTrue(5 == testMathKoans.Pythagorean(4, 3));
        }
        [TestMethod]
        public void TestThatPythagoreanReturns_13_Given_5and12() {
            Assert.IsTrue(13 == testMathKoans.Pythagorean(5, 12));
        }

        //----------START----------Tests for Pythagorean problem
        [TestMethod]
        public void TestThatArrayFirstLastReturns_5_Given_2and3and3() {
            int[] arr = new int[] {2, 3, 3};
            Assert.IsTrue(5 == testMathKoans.ArrayFirstLast(arr));
        }
        [TestMethod]
        public void TestThatArrayFirstLastReturns_6_Given_3and3and3() {
            int[] arr = new int[] { 3, 3, 3 };
            Assert.IsTrue(6 == testMathKoans.ArrayFirstLast(arr));
        }
        [TestMethod]
        public void TestThatArrayFirstLastReturns_0_Given_EmptyArray() {
            int[] arr = new int[0];
            Assert.IsTrue(0 == testMathKoans.ArrayFirstLast(arr));
        } 




    }
    //-------------------------START-------------------------------------------------Tests for String Koans

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
        [TestMethod]
        public void TestFirstLastReturns_ft_Given_feet() {
            Assert.IsTrue("ft" == testStringKoans.FirstLast("feet"));
        }
        [TestMethod]
        public void TestFirstLastReturns_ss_Given_sails() {
            Assert.IsTrue("ss" == testStringKoans.FirstLast("sails"));
        }

        //----------START----------Tests for FizzBuzz problem
        [TestMethod]
        public void TestFizzBuzzReturns_Fizz_Given_funny() {
            Assert.IsTrue("Fizz" == testStringKoans.FizzBuzz("funny"));
        }
        [TestMethod]
        public void TestFizzBuzzReturns_Buzz_Given_bub() {
            Assert.IsTrue("Buzz" == testStringKoans.FizzBuzz("bub"));
        }
        [TestMethod]
        public void TestFizzBuzzReturns_Word_Given_Word_with_no_f_b_at_beginning_or_end() {
            Assert.IsTrue("lad" == testStringKoans.FizzBuzz("lad"));
        }
        [TestMethod]
        public void TestFizzBuzzReturns_FizzBuzz_Given_Fab() {
            Assert.IsTrue("FizzBuzz" == testStringKoans.FizzBuzz("fab"));
        }


        //----------START----------Tests for Dog problem
        [TestMethod]
        public void TestDogReturns_true_Given_dog() {
            Assert.IsTrue(testStringKoans.Dog("dog"));
        }
        [TestMethod]
        public void TestDogReturns_false_Given_bird() {
            Assert.IsFalse(testStringKoans.Dog("bird"));
        }
        [TestMethod]
        public void TestDogReturns_true_Given_dOfasdfg() {
            Assert.IsTrue(testStringKoans.Dog("dOfasdfg"));
        }
        [TestMethod]
        public void TestDogReturns_true_Given_adOfg() {
            Assert.IsTrue(testStringKoans.Dog("adOfg"));
        }

    } 

}
