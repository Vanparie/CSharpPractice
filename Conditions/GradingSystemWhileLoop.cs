
using System;

namespace CSharpPractice
{
    
    internal class GradingSystemWhileLoop
    {
        // Main method
        static void Main(string[] args)
        {
            //Declare variable to store the number the user enters. initialize it with a 0
            int marks = 0;

            //Declare a boolean variable and initialize it with an invalid input
            bool validInput = false;

            // Keep asking until input is valid
            while (!validInput)
            {
                Console.WriteLine("Enter marks (0–100): ");
                string input = Console.ReadLine();

                // Try to convert input to integer
                bool isNumber = int.TryParse(input, out marks);

                // Check if it's a valid number AND within correct range
                if (isNumber && marks >= 0 && marks <= 100)
                {
                    validInput = true; // Exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
                }
            }

            // Grade evaluation with motivational messages
            if (marks >= 90)
            {
                Console.WriteLine("Grade A (90–100)");
                Console.WriteLine("Excellent work! Keep it up!");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade B (80–89)");
                Console.WriteLine("Great job! Aim for an A next time.");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade C (70–79)");
                Console.WriteLine("Good effort. Keep practicing!");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade D (60–69)");
                Console.WriteLine("You passed, but you can do better!");
            }
            else
            {
                Console.WriteLine("Grade F (Below 60): Fail");
                Console.WriteLine("Don't give up. Study harder and try again!");
            }
        }
    }
}
