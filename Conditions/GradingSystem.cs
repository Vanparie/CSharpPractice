using System;

namespace CSharpPractice
{

    internal class GradingSystem
    {

        static void Main(string[] args)
        {
            //take the user input
            Console.WriteLine("Enter marks(0-100): ");

            //print user input on the console
            string userMarks = Console.ReadLine();

            //store marks after parsing
            int marks;

            //try to parse input
            bool IsValid = int.TryParse(userMarks, out marks);

            //perform conditions
            if (IsValid && marks >=0 && marks <=100)
            {
                if (marks >= 90 && marks <= 100)
                {
                    Console.WriteLine("90-100: Grade A");
                }
                else if (marks >= 80 && marks <= 89)
                {
                    Console.WriteLine("80-89: Grade B");
                }
                else if (marks >= 70 && marks <= 79)
                {
                    Console.WriteLine("70-79: Grade C");
                }
                else if (marks >= 60 && marks <= 69)
                {
                    Console.WriteLine("60-69: Grade D");
                }
                else if (marks >= 0 && marks < 60)
                {
                    Console.WriteLine("Below 60: Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! please enter marks between 0 and 100.");
            }

        }
    }
}