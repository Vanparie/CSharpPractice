
using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    
    internal class SquareCalc
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to square: ");
            string input = Console.ReadLine();

            //store number
            int number;

            //convert input to a number
            bool IsValid = int.TryParse(input, out number);

            if(IsValid)
            {
                //Call method and store result
                int result = Square(number);
                Console.WriteLine($"The square of {number} is {result}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            
        }
        //method that calculates and returns the square of a number
        static int Square(int num)
        {
            return num * num;
        }
    }
}
