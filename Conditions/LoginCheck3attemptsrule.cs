
using System;

namespace CSharpPractice
{
    
    internal class LoginCheck3attemptsrule
    {

        static void Main(string[] args)
        {
            //declare correct login credentials
            string correctUsername = "Davidson";
            string correctPassword = "1234";

            //total allowed attempts
            int attemptsLeft = 3;

            while(attemptsLeft > 0)
            {
                Console.WriteLine("Enter username: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (userName == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Welcome, " + userName + "!");
                    //break loop on successful login
                    break;
                }
                else
                {
                    //reduce attempt count
                    attemptsLeft--;

                    Console.WriteLine($"Incorrect credentials. Attempts remaining: {attemptsLeft} \n");


                    if (attemptsLeft ==0)
                    {
                        Console.WriteLine("Too many failed attempts! Account locked.");
                    }
                }
            }
        }
    }
}