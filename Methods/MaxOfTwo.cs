
using System;
using System.Collections.Generic;


namespace CSharpPractice
{
    
    internal class MaxOfTwo
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string input2 = Console.ReadLine();

            bool IsValid1 = int.TryParse(input1, out int num1);
            bool IsValid2 = int.TryParse(input2, out int num2);

            if(IsValid1 && IsValid2)
            {
                //call method and store result
                int max = GetMax(num1, num2);
                Console.WriteLine($"The maximum number is: {max}");
            }
            else
            {
                Console.WriteLine("Invalid input. please enter a valid numeric value.");
            }
        }
        //method that returns the maximum of the two numbers
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
