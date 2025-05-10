using System;


namespace CSharpPractice
{
    //declare class
    internal class SumForLoop
    {
        
        static void Main(string[] args)
        {
            //ask for the user input
            Console.WriteLine("Enter a number(N): ");

            string input = Console.ReadLine();

            //store the number
            int N;

            //convert input to integer

            bool IsValid = int.TryParse(input, out N);

            if(IsValid && N >= 1)
            {
                //initialize sum at 0
                int sum = 0;

                for(int i = 1; i <= N; i++)
                {
                    sum += i;  //same as sum = sum + i;
                }
                Console.WriteLine($"The sum from 1 to {N} is: {sum}");

            }
            else
            {
                Console.WriteLine("Invalid input. please enter a whole number greater than or equal to 1.");
            }
        }
    }
}