using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{

    //-------------------------START-------------------------------------------------Tests for Math Koans

    [TestClass]
    public class TestingBeginnerKoans {
        BeginnerKoans testBeginnerKoans = new BeginnerKoans();


        //----------START----------Tests for is15 problem
        [TestMethod]
        public void TestThatIs15Returns_True_Given_10and5() {
            Assert.IsTrue(testBeginnerKoans.Is15(10,5));
        }
        [TestMethod]
        public void TestThatIs15Returns_False_Given_10and15() {
            Assert.IsFalse(testBeginnerKoans.Is15(10, 15));
        }
        [TestMethod]
        public void TestThatIs15Returns_True_Given_1and14() {
            Assert.IsTrue(testBeginnerKoans.Is15(1, 14));
        }
        [TestMethod]
        public void TestThatIs15Returns_False_Given_1and15() {
            Assert.IsFalse(testBeginnerKoans.Is15(1, 15));
        }
        //----------START----------Tests for isNegative problem
        [TestMethod]
        public void TestThatIsNegativeReturns_True_Given_1and_negative15() {
            Assert.IsTrue(testBeginnerKoans.IsNegative(1, -15));
        }
        [TestMethod]
        public void TestThatIsNegativeReturns_False_Given_1and_15() {
            Assert.IsFalse(testBeginnerKoans.IsNegative(1, 15));
        }
        [TestMethod]
        public void TestThatIsNegativeReturns_True_Given_negative1and_0() {
            Assert.IsTrue(testBeginnerKoans.IsNegative(-1, 0));
        }
        //----------START----------Tests for AddIsAToString problem
        [TestMethod]
        public void TestThatAddIsAToStringReturns_Is_a_cat_given_cat() {
            Assert.IsTrue(testBeginnerKoans.AddIsAToString("cat") == "Is a cat");
        }
        [TestMethod]
        public void TestThatAddIsAToStringReturns_Is_a_dog_given_dog() {
            Assert.IsTrue(testBeginnerKoans.AddIsAToString("dog") == "Is a dog");
        }
        [TestMethod]
        public void TestThatAddIsAToStringReturns_Is_a_frog_given_frog() {
            Assert.IsTrue(testBeginnerKoans.AddIsAToString("frog") == "Is a frog");
        }
        //----------START----------Tests for RemoveChar problem
        [TestMethod]
        public void TestThatRemoveCharReturns_Th_given_theAnd2() {
            Assert.IsTrue(testBeginnerKoans.RemoveChar("The",2) == "Th");
        }

    }


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

        //----------START----------Tests for ArrayFirstLast problem
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
        [TestMethod]
        public void TestThatArrayFirstLastReturns_22_Given_20and2and3and5and1and2() {
            int[] arr = new int[] { 20, 2, 3, 5, 1, 2 };
            Assert.IsTrue(22 == testMathKoans.ArrayFirstLast(arr));
        }

        //----------START----------Tests for CountFive problem
        [TestMethod]
        public void TestThatCountFiveReturns_1_Given_5and3and3() {
            int[] arr = new int[] { 5, 3, 3 };
            Assert.IsTrue(1 == testMathKoans.CountFive(arr));
        }
        [TestMethod]
        public void TestThatCountFiveReturns_0_Given_3and3and3() {
            int[] arr = new int[] { 3, 3, 3 };
            Assert.IsTrue(0 == testMathKoans.CountFive(arr));
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

     //-------------------------START-------------------------------------------------Tests for Array Koans
    [TestClass]
    public class TestingArrayKoans {
        ArrayKoans testArrayKoans = new ArrayKoans();
        //----------START----------Tests for ArrayByTwo problem
        [TestMethod]
        public void TestThatArrayByTwoReturns_TwoAsFirstNum_Given_Array_OneTwoThree() {
            int[] arr = new[] { 1, 2, 3 };
            int[] resultArr = testArrayKoans.ArrayByTwo(arr);
            Assert.IsTrue(resultArr[0] == 2);
        }
        [TestMethod]
        public void TestThatArrayByTwoReturns_TwentyFour_AsFirstNum_Given_Array_TwelveTwoThree() {
            int[] arr = new[] { 12, 2, 3 };
            int[] resultArr = testArrayKoans.ArrayByTwo(arr);
            Assert.IsTrue(resultArr[0] == 24);
        }
        //----------START----------Tests for ArrayWithS problem
        [TestMethod]
        public void TestThatArrayWithSReturns_Strings_AsFirstElement_Given_Array_StringDogAnimal() {
            string[] arr = new[] { "String", "Dog", "Animal" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[0] == "Strings");
        }
        [TestMethod]
        public void TestThatArrayWithSReturns_Dogs_AsSecondElement_Given_Array_StringDogAnimal() {
            string[] arr = new[] { "String", "Dog", "Animal" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[1] == "Dogs");
        }
        [TestMethod]
        public void TestThatArrayWithSReturns_Animals_AsThirdElement_Given_Array_StringDogAnimal() {
            string[] arr = new[] { "String", "Dog", "Animal" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[2] == "Animals");
        }


        //----------START----------Tests for ArrayReverse problem
        [TestMethod]
        public void TestThatArrayReverseReturns_PHP_AsFirstElement_Given_Array_PythonJavaPHP() {
            string[] arr = new[] { "Python", "Java", "PHP" };
            string[] resultArr = testArrayKoans.ArrayReverse(arr);
            Assert.IsTrue(resultArr[0] == "PHP");
        }
        [TestMethod]
        public void TestThatArrayReverseReturns_Python_AsThirdElement_Given_Array_PythonJavaPHP() {
            string[] arr = new[] { "Python", "Java", "PHP" };
            string[] resultArr = testArrayKoans.ArrayReverse(arr);
            Assert.IsTrue(resultArr[2] == "Python");
        }
        [TestMethod]
        public void TestThatArrayReverseReturns_Apple_AsThirdElement_Given_Array_AppleOrangeBanana() {
            string[] arr = new[] { "Apple", "Orange", "Banana" };
            string[] resultArr = testArrayKoans.ArrayReverse(arr);
            Assert.IsTrue(resultArr[2] == "Apple");
        }
        [TestMethod]
        public void TestThatArrayReverseReturns_Orange_AsSecondElement_Given_Array_AppleOrangeBanana() {
            string[] arr = new[] { "Apple", "Orange", "Banana" };
            string[] resultArr = testArrayKoans.ArrayReverse(arr);
            Assert.IsTrue(resultArr[1] == "Orange");
        }

    }

    //-------------------------START-------------------------------------------------Tests for Array Koans
    [TestClass]
    public class TestingLogicKoans {
        LogicKoans testLogicKoans = new LogicKoans();
        //----------START----------Tests for Lottery problem
        [TestMethod]
        public void TestThatLottery_Returns_False_Given_Num_Ten() {
            int num = 10;
            Assert.IsFalse(testLogicKoans.Lottery(num));
        }
        [TestMethod]
        public void TestThatLottery_Returns_True_Given_Num_Twenty() {
            int num = 20;
            Assert.IsTrue(testLogicKoans.Lottery(num));
        }
        [TestMethod]
        public void TestThatLottery_Returns_False_Given_Num_One() {
            int num = 1;
            Assert.IsFalse(testLogicKoans.Lottery(num));
        }


        //----------START----------Tests for LotteryLucky problem
        [TestMethod]
        public void TestThatLotteryLucky_Returns_False_Given_Num_OneandTrue() {
            int num = 1;
            Assert.IsTrue(testLogicKoans.LotteryLucky(num,true));
        }
        [TestMethod]
        public void TestThatLotteryLucky_Returns_False_Given_Num_OneandFalse() {
            int num = 1;
            Assert.IsFalse(testLogicKoans.LotteryLucky(num, false));
        }
    }


}
