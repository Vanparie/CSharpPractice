
using System;

namespace CSharpPractice
{
    internal class MenuCalculator
    {
        static void Main(string[] args)
        {
            //A flag to control the loop.
            
            bool running = true;

            //The loop keeps repeating as long as running is true
            while (running)
            {
                // Display menu
                Console.WriteLine("\n=== Menu-Driven Calculator ===");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1–5): ");    //keeps the cursor on the same line

                //Read user input as a string and store it in the variable choice
                string choice = Console.ReadLine();

                // Start a switch block to check the user’s menu selection
                switch (choice)
                {
                    
                    //Ask for numbers - do the math based on the operation selected.
                    case "1":
                    case "2":
                    case "3":
                    case "4":

                        //Ask for first number
                        Console.Write("Enter first number: ");

                        //safely convert the string to a number
                        //If conversion fails, firstValid becomes false
                        bool firstValid = double.TryParse(Console.ReadLine(), out double num1);

                        //Ask for second number
                        //If conversion fails, secondValid becomes false
                        Console.Write("Enter second number: ");
                        bool secondValid = double.TryParse(Console.ReadLine(), out double num2);


                        //If either number is invalid, print an error and break out of this case (go back to menu).

                        if (!firstValid || !secondValid)
                        {
                            Console.WriteLine("Invalid number input.");
                            break;
                        }

                        //Based on which case was selected ("1", "2", "3", or "4"), perform math.
                        switch (choice)
                        {
                            //Performs addition if choice was "1"
                            case "1":
                                Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                                break;

                            //Subtraction logic
                            case "2":
                                Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                                break;

                            //Multiplication logic.
                            case "3":
                                Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                                break;

                            //Division logic — with safety check to avoid dividing by zero (which would crash the program)
                            case "4":
                                if (num2 != 0)
                                    Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                                else
                                    Console.WriteLine("Cannot divide by zero.");
                                break;
                        }
                        break;


                    //end the while loop, so the program exits
                    case "5":
                        Console.WriteLine("Goodbye!");
                        running = false; // Exit loop
                        break;

                    //Catch any invalid menu choices like 9, hello, etc
                    default:
                        Console.WriteLine("Invalid option. Please choose a number from 1 to 5.");
                        break;
                }
            }
        }
    }
}
