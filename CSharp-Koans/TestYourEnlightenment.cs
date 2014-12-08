using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp_Koans{

    //-------------------------START-------------------------------------------------Tests for Math Koans

    [TestClass]
    public class TestingBeginnerKoans {
        BeginnerKoans testBeginnerKoans = new BeginnerKoans();


        //----------START----------Tests for Is15 problem
        [TestMethod]
        public void TestThatIs15Returns_True_Given_TenAndFive() {
            Assert.IsTrue(testBeginnerKoans.Is15(10,5));
        }
        [TestMethod]
        public void TestThatIs15Returns_True_Given_ZeroAndFifteen() {
            Assert.IsTrue(testBeginnerKoans.Is15(0, 15));
        }
        [TestMethod]
        public void TestThatIs15Returns_False_Given_TenAndFifteen() {
            Assert.IsFalse(testBeginnerKoans.Is15(10, 15));
        }
        [TestMethod]
        public void TestThatIs15Returns_True_Given_OneAndFourteen() {
            Assert.IsTrue(testBeginnerKoans.Is15(1, 14));
        }
        [TestMethod]
        public void TestThatIs15Returns_False_Given_OneAndFifteen() {
            Assert.IsFalse(testBeginnerKoans.Is15(1, 15));
        }
        //----------START----------Tests for isNegative problem
        [TestMethod]
        public void TestThatIsNegativeReturns_True_Given_OneAndNegativeFifteen() {
            Assert.IsTrue(testBeginnerKoans.IsNegative(1, -15));
        }
        [TestMethod]
        public void TestThatIsNegativeReturns_False_Given_OneAndFifteen() {
            Assert.IsFalse(testBeginnerKoans.IsNegative(1, 15));
        }
        [TestMethod]
        public void TestThatIsNegativeReturns_True_Given_negativeOneAndZero() {
            Assert.IsTrue(testBeginnerKoans.IsNegative(-1, 0));
        }
        [TestMethod]
        public void TestThatIsNegativeReturns_False_Given_negativeTwentyOneAndZero() {
            Assert.IsFalse(testBeginnerKoans.IsNegative(21, 0));
        }
        [TestMethod]
        public void TestThatIsNegativeReturns_False_Given_negativeElevenAndTwenty() {
            Assert.IsFalse(testBeginnerKoans.IsNegative(-11, 20));
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
        [TestMethod]
        public void TestThatAddIsAToStringReturns_Is_a_pen_given_pen() {
            Assert.IsTrue(testBeginnerKoans.AddIsAToString("pen") == "Is a pen");
        }
        [TestMethod]
        public void TestThatAddIsAToStringReturns_Is_a_car_given_car() {
            Assert.IsTrue(testBeginnerKoans.AddIsAToString("car") == "Is a car");
        }
        //----------START----------Tests for RemoveChar problem
        [TestMethod]
        public void TestThatRemoveCharReturns_Th_given_theAndTwo() {
            Assert.IsTrue(testBeginnerKoans.RemoveChar("The",2) == "Th");
        }
        [TestMethod]
        public void TestThatRemoveCharReturns_he_given_theAndZero() {
            Assert.IsTrue(testBeginnerKoans.RemoveChar("The", 0) == "he");
        }
        [TestMethod]
        public void TestThatRemoveCharReturns_boolean_given_bbooleanAndOne() {
            Assert.IsTrue(testBeginnerKoans.RemoveChar("bboolean", 1) == "boolean");
        }
        [TestMethod]
        public void TestThatRemoveCharReturns_red_given_fredAndZero() {
            Assert.IsTrue(testBeginnerKoans.RemoveChar("fred", 0) == "red");
        }
        [TestMethod]
        public void TestThatRemoveCharReturns_bad_given_bladAndOne() {
            Assert.IsTrue(testBeginnerKoans.RemoveChar("blad", 1) == "bad");
        }
    }


    //-------------------------START-------------------------------------------------Tests for Math Koans
    [TestClass]
    public class TestingMathKoans {
        MathKoans testMathKoans = new MathKoans();


        //----------START----------Tests for Sum problem
        [TestMethod]
        public void TestThatSumReturns_Four_Given_TwoAndTwo() {
            Assert.IsTrue( 4 == testMathKoans.Sum(2,2));
        }
        [TestMethod]
        public void TestThatSumReturns_Six_Given_ThreeAndThree() {
            Assert.IsTrue(6 == testMathKoans.Sum(3, 3));
        }
        [TestMethod]
        public void TestThatSumReturns_Zero_Given_ZeroAndZero() {
            Assert.IsTrue(0 == testMathKoans.Sum(0, 0));
        }
        [TestMethod]
        public void TestThatSumReturns_OneHundred_Given_FiftyAndFifty() {
            Assert.IsTrue(100 == testMathKoans.Sum(50, 50));
        }
        [TestMethod]
        public void TestThatSumReturns_55_Given_50and5() {
            Assert.IsTrue(55 == testMathKoans.Sum(50, 5));
        }

        //----------START----------Tests for Pythagorean problem
        [TestMethod]
        public void TestThatPythagoreanReturns_Five_Given_FourAndThree() {
            Assert.IsTrue(5 == testMathKoans.Pythagorean(4, 3));
        }
        [TestMethod]
        public void TestThatPythagoreanReturns_Thirteen_Given_FiveAndTwelve() {
            Assert.IsTrue(13 == testMathKoans.Pythagorean(5, 12));
        }
        [TestMethod]
        public void TestThatPythagoreanReturns_Fifty_Given_FortyEightAndFourteen() {
            Assert.IsTrue(50 == testMathKoans.Pythagorean(48, 14));
        }
        [TestMethod]
        public void TestThatPythagoreanReturns_TwentyFive_Given_TwentyFourAndSeven() {
            Assert.IsTrue(25 == testMathKoans.Pythagorean(24, 7));
        }
        [TestMethod]
        public void TestThatPythagoreanReturns_Ten_Given_EightAndSix() {
            Assert.IsTrue(10 == testMathKoans.Pythagorean(8, 6));
        }

        //----------START----------Tests for ArrayFirstLast problem
        [TestMethod]
        public void TestThatArrayFirstLastReturns_Five_Given_TwoAndThreeAndThree() {
            int[] arr = new int[] {2, 3, 3};
            Assert.IsTrue(5 == testMathKoans.ArrayFirstLast(arr));
        }
        [TestMethod]
        public void TestThatArrayFirstLastReturns_Six_Given_ThreeAndThreeAndThree() {
            int[] arr = new int[] { 3, 3, 3 };
            Assert.IsTrue(6 == testMathKoans.ArrayFirstLast(arr));
        }
        [TestMethod]
        public void TestThatArrayFirstLastReturns_Zero_Given_EmptyArray() {
            int[] arr = new int[0];
            Assert.IsTrue(0 == testMathKoans.ArrayFirstLast(arr));
        }
        [TestMethod]
        public void TestThatArrayFirstLastReturns_TwentyTwo_Given_TwentyAndTwoAndThreeAndFiveAndOneAndTwo() {
            int[] arr = new int[] { 20, 2, 3, 5, 1, 2 };
            Assert.IsTrue(22 == testMathKoans.ArrayFirstLast(arr));
        }
        [TestMethod]
        public void TestThatArrayFirstLastReturns_Five_Given_FiveAndOneAndOneAndZero() {
            int[] arr = new int[] { 5, 1, 1, 0  };
            Assert.IsTrue(5 == testMathKoans.ArrayFirstLast(arr));
        }

        //----------START----------Tests for CountFive problem
        [TestMethod]
        public void TestThatCountFiveReturns_One_Given_FiveAndThreeAndThree() {
            int[] arr = new int[] { 5, 3, 3 };
            Assert.IsTrue(1 == testMathKoans.CountFive(arr));
        }
        [TestMethod]
        public void TestThatCountFiveReturns_Zero_Given_ThreeAndThreeAndThree() {
            int[] arr = new int[] { 3, 3, 3 };
            Assert.IsTrue(0 == testMathKoans.CountFive(arr));
        }
        [TestMethod]
        public void TestThatCountFiveReturns_Three_Given_FiveAndFiveAndFive() {
            int[] arr = new int[] { 5, 5, 5 };
            Assert.IsTrue(3 == testMathKoans.CountFive(arr));
        }
        [TestMethod]
        public void TestThatCountFiveReturns_Two_Given_FiveAndFiveAndOne() {
            int[] arr = new int[] { 5, 5, 1 };
            Assert.IsTrue(2 == testMathKoans.CountFive(arr));
        }
        [TestMethod]
        public void TestThatCountFiveReturns_Four_Given_FiveAndFiveAndFiveAndFive() {
            int[] arr = new int[] { 5, 5, 5, 5 };
            Assert.IsTrue(4 == testMathKoans.CountFive(arr));
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
        [TestMethod]
        public void TestThatStringAddReturns_GitHub_Given_GitandHub() {
            Assert.IsTrue("GitHub" == testStringKoans.StringAdd("Git", "Hub"));
        }
        [TestMethod]
        public void TestThatStringAddReturns_CatDog_Given_CatandDog() {
            Assert.IsTrue("CatDog" == testStringKoans.StringAdd("Cat", "Dog"));
        }
        [TestMethod]
        public void TestThatStringAddReturns_Firefighter_Given_Fireandfighter() {
            Assert.IsTrue("Firefighter" == testStringKoans.StringAdd("Fire", "fighter"));
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
        public void TestFizzBuzzReturns_lad_Given_lad() {
            Assert.IsTrue("lad" == testStringKoans.FizzBuzz("lad"));
        }
        [TestMethod]
        public void TestFizzBuzzReturns_FizzBuzz_Given_Fab() {
            Assert.IsTrue("FizzBuzz" == testStringKoans.FizzBuzz("fab"));
        }
        [TestMethod]
        public void TestFizzBuzzReturns_rough_Given_rough() {
            Assert.IsTrue("rough" == testStringKoans.FizzBuzz("rough"));
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
        [TestMethod]
        public void TestDogReturns_false_Given_asdf() {
            Assert.IsFalse(testStringKoans.Dog("asdf"));
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
        [TestMethod]
        public void TestThatArrayByTwoReturns_Four_AsSecondNum_Given_Array_TwelveTwoThree() {
            int[] arr = new[] { 12, 2, 3 };
            int[] resultArr = testArrayKoans.ArrayByTwo(arr);
            Assert.IsTrue(resultArr[1] == 4);
        }
        [TestMethod]
        public void TestThatArrayByTwoReturns_Six_AsThirdNum_Given_Array_TwelveTwoThree() {
            int[] arr = new[] { 12, 2, 3 };
            int[] resultArr = testArrayKoans.ArrayByTwo(arr);
            Assert.IsTrue(resultArr[2] == 6);
        }
        [TestMethod]
        public void TestThatArrayByTwoReturns_0_AsFirstNum_Given_Array_ZeroTwoThree() {
            int[] arr = new[] { 0, 2, 3 };
            int[] resultArr = testArrayKoans.ArrayByTwo(arr);
            Assert.IsTrue(resultArr[0] == 0);
        }

        //----------START----------Tests for ArrayWithS problem
        [TestMethod]
        public void TestThatArrayWithSReturns_Strings_AsFirstElement_Given_Array_StringDogAnimal() {
            string[] arr = new[] { "String", "Dog", "Animal" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[0] == "Strings");
        }
        [TestMethod]
        public void TestThatArrayWithSReturns_Dogs_AsSecondElement_Given_Array_StringDog() {
            string[] arr = new[] { "String", "Dog" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[1] == "Dogs");
        }
        [TestMethod]
        public void TestThatArrayWithSReturns_Basketballs_AsFirstElement_Given_Array_Basketball() {
            string[] arr = new[] { "Basketball" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[0] == "Basketballs");
        }
        [TestMethod]
        public void TestThatArrayWithSReturns_Balls_AsFourthElement_Given_Array_StringDogAnimalBall() {
            string[] arr = new[] { "String", "Dog", "Animal", "Ball" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[3] == "Balls");
        }
        [TestMethod]
        public void TestThatArrayWithSReturns_Kites_AsFirstElement_Given_Array_Kite() {
            string[] arr = new[] { "Kite" };
            string[] resultArr = testArrayKoans.ArrayWithS(arr);
            Assert.IsTrue(resultArr[0] == "Kites");
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
        [TestMethod]
        public void TestThatArrayReverseReturns_Kite_AsFirstElement_Given_Array_ArchAirplaneKite() {
            string[] arr = new[] { "Arch", "Airplane", "Kite" };
            string[] resultArr = testArrayKoans.ArrayReverse(arr);
            Assert.IsTrue(resultArr[0] == "Kite");
        }
        //----------START----------Tests for GreaterThanTen problem
        [TestMethod]
        public void TestThatGreaterThanTen_Returns_False__Given_OneTwoThree() {
            int[] arr = new[] { 1, 2, 3 };
            Assert.IsFalse(testArrayKoans.GreaterThanTen(arr));
        }
        [TestMethod]
        public void TestThatGreaterThanTen_Returns_True__Given_FiveFive() {
            int[] arr = new[] { 5, 5 };
            Assert.IsTrue(testArrayKoans.GreaterThanTen(arr));
        }
        [TestMethod]
        public void TestThatGreaterThanTen_Returns_True__Given_TwentyTwenty() {
            int[] arr = new[] { 20, 20 };
            Assert.IsTrue(testArrayKoans.GreaterThanTen(arr));
        }
        [TestMethod]
        public void TestThatGreaterThanTen_Returns_False__Given_Zero() {
            int[] arr = new[] { 0 };
            Assert.IsFalse(testArrayKoans.GreaterThanTen(arr));
        }
        [TestMethod]
        public void TestThatGreaterThanTen_Returns_False__Given_Ten() {
            int[] arr = new[] { 10 };
            Assert.IsTrue(testArrayKoans.GreaterThanTen(arr));
        }
    }

    //-------------------------START-------------------------------------------------Tests for Logic Koans
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
        [TestMethod]
        public void TestThatLottery_Returns_False_Given_Num_Three() {
            int num = 3;
            Assert.IsFalse(testLogicKoans.Lottery(num));
        }
        [TestMethod]
        public void TestThatLottery_Returns_False_Given_Num_Fifteen() {
            int num = 15;
            Assert.IsFalse(testLogicKoans.Lottery(num));
        }
        //----------START----------Tests for LotteryLucky problem
        [TestMethod]
        public void TestThatLotteryLucky_Returns_False_Given_Num_OneandTrue() {
            Assert.IsTrue(testLogicKoans.LotteryLucky(1,true));
        }
        [TestMethod]
        public void TestThatLotteryLucky_Returns_False_Given_Num_OneandFalse() {
            Assert.IsFalse(testLogicKoans.LotteryLucky(1, false));
        }
        public void TestThatLotteryLucky_Returns_False_Given_Num_FifteenandFalse() {
            Assert.IsFalse(testLogicKoans.LotteryLucky(15, false));
        }
        public void TestThatLotteryLucky_Returns_True_Given_Num_SixteenandTrue() {
            Assert.IsFalse(testLogicKoans.LotteryLucky(16, true));
        }
        public void TestThatLotteryLucky_Returns_False_Given_Num_TwoandFalse() {
            Assert.IsFalse(testLogicKoans.LotteryLucky(2, false));
        }
        //----------START----------Tests for IsLucky problem
        [TestMethod]
        public void TestThatIsLucky_Returns_False_Given_TwoAndThree() {
            Assert.IsFalse(testLogicKoans.IsLucky(2,3));
        }
        [TestMethod]
        public void TestThatIsLucky_Returns_True_Given_SevenAndThree() {
            Assert.IsTrue(testLogicKoans.IsLucky(7, 3));
        }
        [TestMethod]
        public void TestThatIsLucky_Returns_False_Given_EightAndZero() {
            Assert.IsFalse(testLogicKoans.IsLucky(8, 0));
        }
        [TestMethod]
        public void TestThatIsLucky_Returns_True_Given_FourAndThree() {
            Assert.IsTrue(testLogicKoans.IsLucky(4, 3));
        }
        [TestMethod]
        public void TestThatIsLucky_Returns_True_Given_SixAndOne() {
            Assert.IsTrue(testLogicKoans.IsLucky(6, 1));
        }
        //----------START----------Tests for InRange problem
        [TestMethod]
        public void TestThatInRange_Returns_False_Given_Sixteen() {
            Assert.IsFalse(testLogicKoans.InRange(16));
        }
        [TestMethod]
        public void TestThatInRange_Returns_True_Given_Fifteen() {
            Assert.IsTrue(testLogicKoans.InRange(15));
        }
        [TestMethod]
        public void TestThatInRange_Returns_False_Given_Zero() {
            Assert.IsFalse(testLogicKoans.InRange(0));
        }
        [TestMethod]
        public void TestThatInRange_Returns_True_Given_One() {
            Assert.IsTrue(testLogicKoans.InRange(1));
        }
        [TestMethod]
        public void TestThatInRange_Returns_False_Given_NegativeOne() {
            Assert.IsFalse(testLogicKoans.InRange(-1));
        }
        
    }

    //-------------------------START-------------------------------------------------Tests for List Koans
    [TestClass]
    public class TestingListKoans {
        ListKoans testListKoans = new ListKoans();
        //----------START----------Tests for FirstLast1 problem
        [TestMethod]
        public void TestThatFirstLast1_Returns_True_Given_Array_OneTwoThree() {
            int[] arr = new[] { 1, 2, 3 };
            Assert.IsTrue(testListKoans.FirstLast1(arr));
        }
        [TestMethod]
        public void TestThatFirstLast1_Returns_False_Given_Array_TwoTwoThree() {
            int[] arr = new[] { 2, 2, 3 };
            Assert.IsFalse(testListKoans.FirstLast1(arr));
        }
        [TestMethod]
        public void TestThatFirstLast1_Returns_True_Given_Array_TwoThreeFourFiveSixOne() {
            int[] arr = new[] { 2, 3, 4, 5, 6, 1};
            Assert.IsTrue(testListKoans.FirstLast1(arr));
        }
        //----------START----------Tests for SameEnd problem
        [TestMethod]
        public void TestThatSameEnd_Returns_True_Given_Array_ThreeFourFive_and_Array_TwoThreeSixFive() {
            int[] a = new[] { 3, 4, 5 };
            int[] b = new[] { 2, 3, 6, 5 };
            Assert.IsTrue(testListKoans.SameEnd(a,b));
        }
        [TestMethod]
        public void TestThatSameEnd_Returns_False_Given_Array_ThreeFourFive_and_Array_TwoThreeSixSix() {
            int[] a = new[] { 3, 4, 5 };
            int[] b = new[] { 2, 3, 6, 6 };
            Assert.IsFalse(testListKoans.SameEnd(a, b));
        }
        [TestMethod]
        public void TestThatSameEnd_Returns_False_Given_Array_ThreeFourFive_and_Array_TwoThreeSixSevenFive() {
            int[] a = new[] { 3, 4, 5 };
            int[] b = new[] { 2, 3, 6, 7, 5 };
            Assert.IsTrue(testListKoans.SameEnd(a, b));
        }

        //----------START----------Tests for SumAll problem
        [TestMethod]
        public void TestThatSumAll_Returns_Two_Given_Array_OneOne() {
            int[] a = new[] { 1, 1 };
            Assert.IsTrue(testListKoans.SumAll(a) == 2);
        }
        [TestMethod]
        public void TestThatSumAll_Returns_Six_Given_Array_ThreeThree() {
            int[] a = new[] { 3, 3 };
            Assert.IsTrue(testListKoans.SumAll(a) == 6);
        }
        [TestMethod]
        public void TestThatSumAll_Returns_Zero_Given_Array_Zero() {
            int[] a = new[] { 0 };
            Assert.IsTrue(testListKoans.SumAll(a) == 0);
        }
        //----------START----------Tests for FirstLastSum problem
        [TestMethod]
        public void TestThatFirstLastSum_Returns_2_Given_Array_OneOne() {
            int[] a = new[] { 1, 1 };
            Assert.IsTrue(testListKoans.FirstLastSum(a) == 2);
        }
        [TestMethod]
        public void TestThatFirstLastSum_Returns_3_Given_Array_OneTenTwo() {
            int[] a = new[] { 1, 10, 2 };
            Assert.IsTrue(testListKoans.FirstLastSum(a) == 3);
        }
        [TestMethod]
        public void TestThatFirstLastSum_Returns_10_Given_Array_TenTenZero() {
            int[] a = new[] { 10, 10, 0 };
            Assert.IsTrue(testListKoans.FirstLastSum(a) == 10);
        }

    }
}
