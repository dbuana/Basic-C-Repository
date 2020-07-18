using System;

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
            if (int(UserInterface) > 6 {
                Console.WriteLine("Yes!");
            } if (int(UserInterface) < 6) {
                Console.WriteLine("Yes again!");
            } if (int(UserInterface) == 6) {
                Console.WriteLine("Positive!");
            }
        }
    }
}

// Creating a guessing game program - The extended version of the previous program.
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
