
using System;


namespace CSharpPractice
{

    internal class LoginCheck
    {

        static void Main(string[] args)
        {
            //define correct credentials
            string correctUsername = "Davidson";
            string correctPassword = "1234";


            bool IsAuthenticated = false;


            // Keep asking until the credentials are correct
            while (!IsAuthenticated)
            {
                //ask user to enter credentials
                Console.WriteLine("Enter username: ");
                string Username = Console.ReadLine();

                Console.WriteLine("Enter password");
                string Password = Console.ReadLine();

                if (Username == correctUsername && Password == correctPassword)
                {
                    Console.WriteLine("Welcome, " + Username + "!");
                    IsAuthenticated = true;  //exit the loop
                }
                else
                {
                    Console.WriteLine("Incorrect credentials. Please try again. \n");
                }
            }

        }
    }
}