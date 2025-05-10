//import system namespace

using System;

//group class together

namespace CSharpPractice
{
    //declare class
    internal class ArrayScores
    {
        //main method
        static void Main(string[] args)
        {
            //step 1: declare an array to store 5 scores

            int[] scores = new int[5];

            Console.WriteLine("Enter 5 exam scores (0-100):");

            //step 2: use a loop to input the scores
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Enter score #{i + 1}: ");

                bool IsValid = int.TryParse(Console.ReadLine(), out scores[i]);

                //check if input is valid and within range
                if(!IsValid || scores[i] < 0 || scores[i] > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    i--;   //retry this index

                }
            }
            //step 3: calculate total
            int total = 0;

            foreach(int score in scores)
            {
                total += score;
            }

            //step 4: calculate average
            double average = (double)total / scores.Length;

            //step 5: display result
            Console.WriteLine($"\n Average score: {average:F2}");
        }
    }
}