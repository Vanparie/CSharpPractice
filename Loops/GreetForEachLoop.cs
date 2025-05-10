
using System;

namespace CSharpPractice
{
   
    internal class GreetForEachLoop
    {

        static void Main(string[] args)
        {
            //declare and initialize an array of names
            string[] names = { "Alice", "Bob", "Carol" };

            //loop over each item in the array
            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name}!");

            }

        }
    }
}