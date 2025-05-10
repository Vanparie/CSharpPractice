using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    internal class CountEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers: ");

            int[] even = { 1, 2, 3, 4, 5, 6 };

            foreach(int i in even)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
