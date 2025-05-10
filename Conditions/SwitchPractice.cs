
using System;

namespace CSharpPractice
{

    internal class SwitchPractice
    {

        static void Main(string[] args)
        {
            //ask for user input
            Console.WriteLine("Enter a number(1-7): ");
            
            string input = Console.ReadLine();
            int num;

            //try to convert input to int

            bool IsValid = int.TryParse(input, out num);

            if(IsValid)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid number! please enter a number between 1 and 7.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid input! please enter a numeric value.");
            }
        }
    }
}
