//import system namespace
using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    
    internal class IsEven
    {
        
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter a number to check if it is even: ");

            string input = Console.ReadLine();

            //safely convert input to a number

            bool IsValid = int.TryParse(input, out int number);

            //check if number is valid
            if(IsValid)
            {
                bool result = IsNumberEven(number);

                if (result)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }

        // Method to check if a number is even
        static bool IsNumberEven(int num)
        {
            return num % 2 == 0;
        }


    }
}
