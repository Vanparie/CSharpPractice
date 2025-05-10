using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    internal class ToDoList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a task:");
            List<string> tasks = new List<string>();

            tasks.Add(Console.ReadLine());
            tasks.Add("Write code.");
            tasks.Add("Watch a movie.");
            tasks.Add("Watch a football match.");
            tasks.Add("Do assignments.");

            Console.Write("Task done? Remove by typing it: ");
            string done = Console.ReadLine();
            tasks.Remove(done);


            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
