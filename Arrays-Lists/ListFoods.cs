using System;
using System.Collections.Generic;


namespace CSharpPractice
{
    internal class ListFoods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favorite foods: ");
            List<string> foods = new List<string>();

            foods.Add("Rice");
            foods.Add("Maize");
            foods.Add("Milk");
            foods.Remove("Rice");

            foreach(string food in foods)
            {
                Console.WriteLine(food);
            }
        }
    }
}
