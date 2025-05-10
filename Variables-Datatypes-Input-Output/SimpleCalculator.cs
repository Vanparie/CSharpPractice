using System;


namespace CSharpPractice
{

    internal class SimpleCalculator
    {

        static void Main(string[] args)
        {
            //get user input on the first number
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //get user input on the second number
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //let the user choose an operation
            Console.WriteLine("Choose an operation(+, -, *, /): ");
            string operation = Console.ReadLine();

            //perform conditions on the operation

            if (operation == "+")
            {
                Console.WriteLine("Result: " + (num1 + num2));
            }
            else if (operation == "-")
            {
                Console.WriteLine("Result: " + (num1 - num2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("Result: " + (num1 * num2));
            }
            else if (operation == "/")
            {
                //handle division by zero
                if (num2 != 0)
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Error! number not divisible by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter +, -, *, or /");
            }
        }
    }
}