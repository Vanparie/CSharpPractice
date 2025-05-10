using System;

namespace CSharpPractice
{
    internal class ForLoopEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers between 1 and 50: ");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)          //check if i is divisible by 2(even)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
