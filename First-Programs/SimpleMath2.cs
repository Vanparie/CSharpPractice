//CHALLENGE 2.1

using System;

namespace CSharpPractice
{
    internal class SimpleMath2
    {
        static void Main(string[] args)
        {
            //take user first number
            Console.WriteLine("Enter first number: ");

            //convert number to integer

            int num1 = Convert.ToInt32(Console.ReadLine());

            //take user second number
            Console.WriteLine("Enter second number: ");

            //convert number to integer
            
            int num2 = Convert.ToInt32(Console.ReadLine());

            //perform calculations
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            //handle division by zero
            if (num2 != 0)
            {
                Console.WriteLine("Division: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Number cannot be divided by zero!");
            }
            

           
            //print the output
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
        }
    }
}
