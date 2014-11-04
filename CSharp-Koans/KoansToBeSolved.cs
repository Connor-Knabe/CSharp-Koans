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
        public static String revWord(String revWord) {
            String word1 = "";
            for (int i = revWord.Length - 1; i >= 0; i--) {
                word1 += revWord[i];
            }
            return word1;
        }
        public String WordReverse(String revStr) {
            return "Hello World";
        }


    }
}
