/* 
BONUS CHALLENGE – Day 1 Closing Challenge: "Voting Eligibility Checker"
Challenge Description:
Write a C# program that:
Asks the user to enter their age.
Checks if:
If age is 18 or older, print:
"You are eligible to vote."
If age is less than 18, print:
"You are not eligible to vote yet."
If the user enters non-numeric input, show:
"Invalid input! Please enter a number."
Use int.TryParse() to handle wrong inputs.
Use if-else to decide eligibility.
*/



using System;


namespace CSharpPractice
{
    //Declare class
    internal class VotingEligibilityChecker
    {
        //main method
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter your age: ");

            //print user input on the console
            string userInput = Console.ReadLine();

            //store number after parsing
            int userAge;

            //try to parse input
            bool IsValid = int.TryParse(userInput, out userAge);

            if (IsValid)
            {
                //if input is a valid number, check eligibility
                if (userAge >= 18)
                {
                    Console.WriteLine("You are eligible to vote");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote yet.");
                }
            }
            
            else
            {
                //if input is not a number
                Console.WriteLine("Invalid input! please enter a number.");
            }
        }
    }
}