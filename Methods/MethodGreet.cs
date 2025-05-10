//import system namespace
using System;
using System.Collections.Generic;

//group class together
namespace CSharpPractice
{
    //declare class
    internal class MethodGreet
    {
        //main method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            //call the method with user's input
            GreetUser(userName);
        }
        //custom method that greets user
        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to day 6.");
        }
    }
}
