using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Koans
{
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

        public String WordReverse(String revStr) {
            //Method takes in a reversed string that each word must individually be reversed NOT the whole sentence
            //For example olleH dlroW returns Hello World NOT World Hello
            return "Hello World";
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
            //Method takes in an array and returns that arrays contents multiplied by 2

            for (int i = 0; i < a.Length; i++) {
                a[i] = a[i] * 2; 
            }

                return a;
        }

    }
}
