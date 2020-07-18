using System;

// A program that finds even or odd numbers.
public class EvenOrOdd {

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
        }
    }
}
