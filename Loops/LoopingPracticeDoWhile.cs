
using System;


namespace CSharpPractice
{
    //declare class
    internal class LoopingPracticeDoWhile
    {
        //main method
        static void Main(string[] args)
        {
            //start with a counter
            int i = 1;

            //check condition
            do
            {
                //print current value of i
                Console.WriteLine(i);

                //increase i by 1(increment)
                i++;
            } while (i <= 10);
        }
    }
}
