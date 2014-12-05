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
            return (15==x+y);
        }
        public bool IsNegative(int x, int y) {
            //Method takes in two values and returns true if their sum is negative
            return (x+y<0);
        }

        public string AddIsAToString(string a) {
            //Method takes in a string and returns that string with Is a before it
            return "Is a "+a;
        }
        public string RemoveChar(string a, int indexToRemove) {
            //Method takes in a string and returns that string with a character removed at index given
            String front = a.Substring(0, indexToRemove);
            String back = a.Substring(indexToRemove + 1);
            return front+back;
        }

    }


    class MathKoans {

        public int Sum (int x, int y){
            //Method takes in two values and returns both numbers added together
            return x+y;
        }
        public double Pythagorean(double a, double b) {
            //Method takes in two values and returns the square of both added together a^2+b^2 = c^2 return c
            double c = Math.Pow(a,2) + Math.Pow(b,2);
            
            return Math.Sqrt(c);
        }

        public int ArrayFirstLast(int[] arr) {
            //Method takes in array of dynamic size that adds the first and last number returning the sum of these two numbers.
            if (arr.Length==0) return 0;

            int a = arr[0];
            int b = arr[arr.Length - 1];
            return a + b;
        }

        public int CountFive(int[] arr) {
            //Method takes in array of dynamic size that counts number of times 5 appears.
            int fiveTotal = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == 5) {
                    fiveTotal++;
                }
            }
                return fiveTotal;
        }

    }


    class StringKoans {
        public String StringAdd(String x, String y) {
            //Method takes in two strings and returns both strings concatenated together 
            return x + y;
        }
        public String FirstLast(String word) {
            //Method takes in a word and returns the first and last character concatenated together
            return word.Substring(0, 1) + word.Substring(word.Length - 1);
        }

        public String FizzBuzz(String word) {
            //Method that takes in a word. If the word starts with "f" return "Fizz". If the word ends with "b" return "Buzz" if the word contains both return "FizzBuzz"
            bool f = word.Substring(0, 1) == "f";
            bool b = word.Substring(word.Length - 1) == "b";
            if (f && b) return "FizzBuzz";
            if (f) return "Fizz";
            if (b) return "Buzz";

            return word;
        }

        public bool Dog(String word) {
            //Method that takes in a word. If the word contains d o g in any order return true else return false. Case insensitive will also accept D o G etc.
            bool d = false;
            bool o = false;
            bool g = false;
            for (int i = 0; i < word.Length; i++) {
                if (word[i] == 'd' || word[i] == 'D') {
                    d = true;
                }
                if (word[i] == 'o' || word[i] == 'O') {
                    o = true;
                }
                if (word[i] == 'g' || word[i] == 'G') {
                    g = true;
                }
            }
            return d && o && g;
        }

    }

    class ArrayKoans {
        public int[] ArrayByTwo(int[] a) {
            //Method takes in an array containing numbers and returns that arrays contents multiplied by 2
            for (int i = 0; i < a.Length; i++) {
                a[i] = a[i] * 2; 
            }
                return a;
        }
        public string[] ArrayWithS(string[] a) {
            //Method takes in an array of strings and returns that arrays contents with an s at end
            for (int i = 0; i < a.Length; i++) {
                a[i] = a[i] +"s";
            }
            return a;
        }
        public string[] ArrayReverse(string[] a) {
            //Method takes in an array of strings and returns that arrays reversed
            Array.Reverse(a);
            return a;
        }
    }

    class LogicKoans {

        public bool Lottery(int num) {
            //Method takes in an number, if the number is greater than 15 return true else return false
            return (num>15);
        }
        public bool LotteryLucky(int num, bool weekend) {
            //Method takes in an number, if the number is greater than 15 return true else return false unless it is on weekend then return true no matter what
            if (weekend){
                return true;
            } else {
                return (num > 15);
            }
        }
        public bool IsLucky(int a, int b) {
            //Method takes in two numbers if one of the numbers is 7 or both numbers add up to 7 return true else return false
            if (a == 7 || b == 7) {
                return true;
            } else if (a + b == 7) {
                return true;
            } else {
                return false;
            }
        }
        public bool InRange(int a) {
            //Method takes in a number the number is in between range 1-15 inclusive return true else return false
            return false;
        }




    }

    class ListKoans {

        public bool FirstLast1(int[] nums) {
            //Method takes in an array of integers, if the array has 1 as the first or last element return true else return false
            if (nums[0]==1 || nums[nums.Length-1]==1){
                return true;
            } else {
                return false;
            }
        }
        public bool SameEnd(int[] a, int[] b) {
            //Method takes in an two arrays of integers, if both arrays have the same last number return true else return false
            return (a[a.Length - 1] == b[b.Length - 1]);
        }
        public int SumAll(int[] a) {
            //Method takes in an arrays of integers and then returns the sum of that array.
            int total = 0 ;
            for (int i = 0; i < a.Length; i++) {
                total += a[i];
            }
            return total;
        
        }
    }
}
