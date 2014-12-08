using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Koans
{

    class BeginnerKoans {

        public bool Is15 (int x, int y) {
            //Method takes in two values and returns true if they add up to 15
            return false;
        }
        public bool IsNegative(int x, int y) {
            //Method takes in two values and returns true if their sum is negative
            return false;
        }

        public string AddIsAToString(string a) {
            //Method takes in a string and returns that string with Is a before it
            return "";
        }
        public string RemoveChar(string a, int indexToRemove) {
            //Method takes in a string and returns that string with a character removed at index given

            return "";
        }

    }


    class MathKoans {

        public int Sum (int x, int y){
            //Method takes in two values and returns both numbers added together
            return 1;
        }
        public double Pythagorean(double a, double b) {
            //Method takes in two values and returns the square of both added together a^2+b^2 = c^2 return c            
            return 1;
        }

        public int ArrayFirstLast(int[] arr) {
            //Method takes in array of dynamic size that adds the first and last number returning the sum of these two numbers.
            return 1;
        }

        public int CountFive(int[] arr) {
            //Method takes in array of dynamic size that counts number of times 5 appears.
                return 1;
        }

    }


    class StringKoans {
        public String StringAdd(String x, String y) {
            //Method takes in two strings and returns both strings concatenated together 
            return "";
        }
        public String FirstLast(String word) {
            //Method takes in a word and returns the first and last character concatenated together
            return "";
        }

        public String FizzBuzz(String word) {
            //Method that takes in a word. If the word starts with "f" return "Fizz". If the word ends with "b" return "Buzz" if the word contains both return "FizzBuzz"
            return "";
        }

        public bool Dog(String word) {
            //Method that takes in a word. If the word contains d o g in any order return true else return false. Case insensitive will also accept D o G etc.
            return false;
        }
    }

    class ArrayKoans {
        public int[] ArrayByTwo(int[] a) {
            //Method takes in an array containing numbers and returns that arrays contents multiplied by 2
                return a;
        }
        public string[] ArrayWithS(string[] a) {
            //Method takes in an array of strings and returns that arrays contents with an s at end
            return a;
        }
        public string[] ArrayReverse(string[] a) {
            //Method takes in an array of strings and returns that arrays reversed
            return a;
        }
        public bool GreaterThanTen(int[] a) {
            //Method takes in an array of integers and returns true if the sum adds up to a total of 10 or more inclusive
            return false;
        }
    }

    class LogicKoans {

        public bool Lottery(int num) {
            //Method takes in an number, if the number is greater than 15 return true else return false
            return false;
        }
        public bool LotteryLucky(int num, bool weekend) {
            //Method takes in an number, if the number is greater than 15 return true else return false unless it is on weekend then return true no matter what
            return false;
        }
        public bool IsLucky(int a, int b) {
            //Method takes in two numbers if one of the numbers is 7 or both numbers add up to 7 return true else return false
            return false;
        }
        public bool InRange(int a) {
            //Method takes in a number the number is in between range 1-15 inclusive return true else return false
            return false;
        }
    }

    class ListKoans {

        public bool FirstLast1(int[] nums) {
            //Method takes in an array of integers, if the array has 1 as the first or last element return true else return false
            return false;
        }
        public bool SameEnd(int[] a, int[] b) {
            //Method takes in an two arrays of integers, if both arrays have the same last number return true else return false
            return false;
        }
        public int SumAll(int[] a) {
            //Method takes in an arrays of integers and then returns the sum of that array.
            return 1;
        }
        public int FirstLastSum(int[] a) {
            //Method takes in an arrays of integers and then returns the sum of the first and last integers.
            return 1;
        }
    }
}
