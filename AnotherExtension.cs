using System;

// A basic C# program
namespace BasicProgramming(){

    // class Program - It is giving an information, to the program; that this module is a computer program.
    class Program{

        // To make sure that the program is aware that a string is being written. 
        static void Main(string[] args){
            // Executing a simple message
            Console.WriteLine("Hello, World!");
            // Variable types
            int a = 1;
            char b = 2;
            float c = 3.5;
            bool d = True;
            bool dTwo = False;
            string e = "Hey!";
            // Retrieving the variables
            Console.ReadKey(e);
        }
        // Creating the basic function. In C# are written within parameter of a program
        // as shown above; the "BasicProgramming" parameter, contains many functions.
        void FirstFunction(){
            return Console.WriteLine("Hey, Guys!");
        }
        // Combing each variables
        void Combining_Variables(){
            // A brief example of how variables are combined
            x = Console.WriteLine("Hello, " + e);
            y = Console.WriteLine("There are " + string(a) + string(b));
            return x, y
        }
        // A function can also be written with implementation of variable types
        bool validatingFunction(a>0){
            return True;
        }
        // Implementing "if and else" statements. 
        bool condition = True;
        // The statement
        if (condition==True){
            Console.WriteLine("Very true!");
        } else {
            Console.WriteLine("False indeed!");
        }
        // A validation function; checks whether a certain number is bigger, than the other.
        int i = 6;
        int s = 8;
        if (i<s){
            Console.WriteLine("Very True!");
        } else {
            Console.WriteLine("False Indeed!");
        }
    }
}

// First project with C#
// Objective: Create a user-interface, then create a validation statement to match the user-input.
public class InterfaceValidation{

    class Program {

        static void Main(string[] args){
            // User-interface in C#
            string UserInterface;
            Console.Write("Type in a number: ");
            UserInterface = Console.ReadLine();
            // The validation statement
            if (int(UserInterface) > 46 {
                Console.WriteLine("Yes!");
            } if (int(UserInterface) < 6) {
                Console.WriteLine("Yes again!");
            } if (int(UserInterface) == 6) {
                Console.WriteLine("Positive!");
            }
        }
    }
}

// Creating a guessing game program
public class RandomGuessingGame {

    class Program {
        
        static void Main(string[] args){
            // The random number generator secetion
            var number = new Random(0,9);
            var generator = console.WriteLine(number);
            // User-interface will be a major contribution to this program
            string UserInterface;
            Console.Write("Type in a number: ");
            UserInterface= Console.ReadLine();
            // The statement, it will be the main engine of the program
            if (UserInterface == 6){
                Console.WriteLine("You got it right!");
            } (UserInterface >= 6) {
                Console.WriteLine("Too much!");
            } (UserInterface <= 6) {
                Console.WriteLine("Too little!");
            }
        }
    }
}

// Basic challenges with C#

// Program that executes strings
namespace NameUser {
    class Program {
        static void Main(string[] args){
            // Type in the name of the user
            Console.WriteLine("Davian Buana");
        }
    }
}

// Program that returns arithematic values
public class Arithematics {
    class Program {
        static void Main(string[] args){
            // Vairiables to increase the sophistication
            a = 5;
            b = 7;
            // Calling the two variables
            Console.WriteLine(a+b);
            Console.WriteLine(a/b);
            Console.WriteLine(a*b);
            Console.WriteLine(a-b);
            // Each holds a sentimental arithematic value; in perspective of legendary mathematicians
        }
    }
}

// Program that swaps variables
public class VariableSwapping {

    class Program {
        
        static void Main(string[] args){

            int firstNumber, secondNumber, attempt;
            // A user input will play a major role
            Console.WriteLine("The first number: ")
            firstNumber = int.Parse(Console.ReadLine())
            Console.WriteLine("The second number: ");
            secondNumber = int.Parse(Console.ReadLine())
            // Updating the variables
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            // The final results
            Console.WriteLine("The first number: " + firstNumber);
            Console.WriteLine("the second number: " + secondNumber);
            // Finish
        }
    }
}

// Multiplication interface; User inputs  a number, then it returns it's times table; until 5. 
public class TimesInterface {

    class Program {

        static void Main(string[] args){
            // User-interface; another major contributor to the program
            int userNumber; 
            Console.WriteLine(usernumber);
            userNumber = int.Parse(Console.ReadLine())
            }
            // Validation statement not needed; instead a function will assist the user to the result\
            void TimesTable() {
                // TImes table in order, with respect to the user-interface
                string one = userInterface*str(1);
                string two = userInterface*str(2);
                string three = userInterface*str(3);
                string four = userInterface*str(4);
                string five = userInterface*str(5);
                // Calling all the variables
        }
    }
}

// A program that finds the average of a number sequence and validates, whether the numbers are even.
public class FindingTheAverage {

    class Program {
        
        static void Main(string[] args){
            // The user-input will be set as "int" variables
            int userOne, userTwo, userThree; // Just the empty variables
            // Filling their potentials 
            Console.WriteLine(userOne);
            Console.WriteLine(userTwo);
            Console.WriteLine(userTwo);
            // Advancements and sophistication implied
            userOne = int.Parser(Console.ReadLine(userOne));
            userTwo = int.Parser(Console.ReadLine(userTwo));
            userThree = int.Parser(Console.readLine(userThree));
            // Validation statement
            if (userOne and userTwo and userThree % 2 == 0){
                Console.WriteLine("Even");
            } else {
                Console.WriteLine("Odd");
            }
            void TheAverage() {
                // Empty variables
                int userOne, userTwo, userThree;
                int result;
                // The statements will find the common factors of the numbers
                var userOne = userOne%0;
                var userTwo = userTwo%0;
                var userThree = userThree%0;
                // Validation variable
                if (userOne and usertwo and userThree%0 == result){
                    Console.WriteLine(result);
                } else {
                    Console.WriteLine("Does not contain any");
                }
                // Executing the values with the "return" function
                return Console.WriteLine("The average value of " + userOne + userTwo + " and "+ userthree + " is "); // Continue the code)
            }
            Console.WriteLine(TheAverage);
        }
    }
}