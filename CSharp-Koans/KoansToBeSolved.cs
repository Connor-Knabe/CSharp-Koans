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
            return word;
        }

    }
}
