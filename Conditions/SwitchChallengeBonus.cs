
using System;


namespace CSharpPractice
{
    
    internal class SwitchChallengeBonus
    {
        
        static void Main(string[] args)
        {
            //get the user input
            Console.WriteLine("Enter your grade(A,B,C,D,F): ");

            //Convert to uppercase for consistency
            string grade = Console.ReadLine().ToUpper();


            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent work! keep up!");
                    break;
                case "B":
                    Console.WriteLine("Good job! next time, aim for an A.");
                    break;
                case "C":
                    Console.WriteLine("Good. you can do better next time.");
                    break;
                case "D":
                    Console.WriteLine("You passed. There is room for improvement.");
                    break;
                case "F":
                    Console.WriteLine("You have failed. please try again.");
                    break;
                default:
                    Console.WriteLine("Invalid grade! please enter grade A,B,C,D or F.");
                    break;
            }


        }
    }
}
