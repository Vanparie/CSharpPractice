using System;

namespace CSharpPractice
{
    internal class GreetForEach2
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Enter 5 names:");

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name {i + 1}:");
                names[i] = Console.ReadLine();
            }
            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name}!");
            }

        }
    }
}