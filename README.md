#CSharp-Koans#

##CSharp-Koans using TDD.##

####How to use:####
https://github.com/Connor-Knabe/CSharp-Koans
1. Clone this repo 
<br />
2. Open the project using Visual Studio
<br />
3. Begin by opening the KoansToBeSolved.cs file
<br />
4. In this file there are method that you must implement
<br />
5. To check to see your progress click Test(navigation bar) > Run > All tests
<br />
6. All tests associated with that method will pass if you have solved the Koan correctly
<br />
7. Work until all problems are solved and/or you gain enlightenment


###Documentation.###

#####Introduction:#####

Inspiration for this project came from http://rubykoans.com/ which can be found at https://github.com/neo/ruby_koans

The whole idea behind this C# project is to help people who are just starting off with the C# language to learn the syntax, methods, and Test Driven Development.
The idea behind Test Driven Development(TDD) is that you write tests first which fail and then implement the code which will make the test pass.

If you are interested in more coding challenges similar to this then you may want to also look into Javascript Koans located at https://github.com/mrdavidlaing/javascript-koans 


#####Things to keep in mind:#####

The KoansToBeSolved.cs file is the only file you need to make changes too.  

Some of the tests will pass from the beginning since there are tests that check for the method to return false or true.  

In order to know that you have completed the method correctly you would want to verify to see that above the method it says all of the tests are passing.  For example the Is15 method should say 4 references | 4/4 passing. If you click on that it will pull up all of the tests that are associated with that method.


#####Program Structure:#####
The answers to these problems are located in the KoanAnswers.cs file which is in the CSharp-Koans folder.

There are two important files in the CSharp-Koans project one with the tests named “TestYourEnlightenment.cs” and one with the methods you must implement “KoansToBeSolved.cs”

Both files are broken down into various classes and methods which correspond to the type of question you must solve.  

The different types of questions include:

* Beginner
* Math
* String
* Array
* Logic
* List

With in these question classes there are methods that need to be solved.

In the TestYourEnlightenment.cs file there are also methods and classes that correspond to the KoansToBeSolved.cs file.

An example of a test that will be checking to see if you have implemented the method correctly would be .
 ```
[TestClass]
public class TestingBeginnerKoans {
	BeginnerKoans testBeginnerKoans = new BeginnerKoans();
	//----------START----------Tests for Is15 problem
	[TestMethod]
	public void TestThatIs15Returns_True_Given_10and5() {
		Assert.IsTrue(testBeginnerKoans.Is15(10,5));
	}
}
```

You can see that there is a class and method being tested here and 10,5 are being passed into this method which should return true because the method is checking to see if given two values their sum is 15.

