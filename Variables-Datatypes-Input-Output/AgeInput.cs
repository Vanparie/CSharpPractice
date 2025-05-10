
//Handling wrong user input


using System;


namespace CSharpPractice

{
    internal class AgeInput
    {
        
        static void Main(string[] args)
        {
            //take user input
            Console.WriteLine("Enter your age: ");

            string userInput = Console.ReadLine();
            int userAge;   //store the number after parsing

            //try to parse the input/ try to parse userInput into an integer

            bool IsValid = int.TryParse(userInput, out userAge);

            if (IsValid)
            {
                //successfully converted
                Console.WriteLine("Your age is: " + userAge);

            }
            else
            {
                //conversion failed
                Console.WriteLine("Invalid input! Please enter numbers only.");
            }

        }
    }
}



