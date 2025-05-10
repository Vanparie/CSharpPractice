using System;


namespace CSharpPractice
{

    internal class LoopPracticeWhile
    {

        static void Main(string[] args)
        {
            //start with a counter
            int i = 1;

            //check condition before loop runs
            while (i <= 10) 
            {
                //print current value of i
                Console.WriteLine(i);

                //increase i by 1(increment)
                i++;
            }
        }
    }
}