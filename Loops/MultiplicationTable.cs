using System;


namespace CSharpPractice
{
    //declare class
    internal class MultiplicationTable
    {
        //main method
        static void Main(string[] args)
        {
            //ask for user input
            Console.WriteLine("Enter a number to display its multiplication table: ");
            string input = Console.ReadLine();

            //store the number
            int num;

            //try to parse the string as integer
            bool IsValid = int.TryParse(input, out num);

            if(IsValid)
            {
                Console.WriteLine($"Multiplication table for {num}: ");

                for(int i = 1; i <= 10; i++)
                {
                    int product = num * i;
                    Console.WriteLine($"{num} * {i} = {product}");

                }

            }
            else
            {
                Console.WriteLine("Invalid input. please enter a numeric value.");
            }
        }
    }
}