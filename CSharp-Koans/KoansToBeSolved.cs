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

            /*
             * 
             * 
             * 
            	public static String revWord(String revWord){
        String word1 = "";
		for (int i = revWord.length()-1; i >= 0; i--){
			word1 += revWord.charAt(i);
		}
		return word1;
	} 

    public static void main(String[] args) {
        String str = "";
        String revStr = "olleH dlroW";
        int lastWordIndex = 0;
        char curLetter;
        for (int i = 0; i<revStr.length(); i++){
        	curLetter = revStr.charAt(i);
        	if (curLetter == ' '){
        		str += revWord(revStr.substring(0,i));
        		//Add space because space was detected between words
        		str += " ";
        		lastWordIndex = i;
        	} else if (i==revStr.length()-1){
        		str += revWord(revStr.substring(lastWordIndex,i+1));
        	}
        }
    	System.out.println("Reversed string is: " + revStr);

        System.out.println("Final string is: " + str);
        
    }*/

            return "aa";
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

            return false;
        }

    }
}
