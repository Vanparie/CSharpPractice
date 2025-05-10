//CHALLENGE 3

/*
Create a file called PersonalDetails.cs.
Ask the user:
What is your name?
What is your age?
What is your profession?
Then print a formatted sentence:
*/



using System;


namespace CSharpPractice
{
    //Declare class
    internal class PersonalDetails
    {
        //main method
        static void Main(string[] args)
        {
            //get user name
            Console.WriteLine("What is your name?: ");

            //print name on console
            string userName = Console.ReadLine();

            //get user age
            Console.WriteLine("What is your age?: ");

            //print age on console
            string userAge = Console.ReadLine();

            //handle non-numeric entries

            //get user profession
            Console.WriteLine("What is your profession?: ");

            //print profession on console
            string userProfession = Console.ReadLine();


            //print a formatted sentence

            Console.WriteLine("Hello, " + userName + ("! You are " + userAge + " years old" + " and you are a " + userProfession + ". Cheers!"));



        }
    }
}