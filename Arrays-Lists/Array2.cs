//import system namespace

using System;

//group class together

namespace CSharpPractice
{
    //declare class
    internal class Array2
    {
        //main method
        static void Main(string[] args)
        {
            Console.WriteLine("Student names: ");

            string[] names = { "Dave", "Melo", "TJ" };
            
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}