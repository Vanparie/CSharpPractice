//CHALLENGE 2

/*
Create a file called SimpleMath.cs.

Ask the user for two numbers.

Calculate and display:

Their sum

Their difference

Their product

Their quotient (division) 
*/


using System;


namespace CSharpPractice
{
    //Declare class
    internal class SimpleMath
    {
        //main method
        static void Main(string[] args)
        {
            //ask for the user input
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


            //perform calculations
            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Difference: " + (num1 - num2));
            Console.WriteLine("Product: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));
        }
    }
}