//import system namespace
using System;

//group related classes together
namespace CSharpPractice
{
    //define the car class(blueprint for car objects)
    class Car
    {
        //declare public fields for each car
        public string Brand;
        public int Year;
        public string Color;

        //method to display info about the car
        public void DisplayInfo()
        {
            //print car details using their fields
            Console.WriteLine($"Car Brand: {Brand}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
        }
    }
    //define another class - entry point of the program
    internal class Program
    {
        //main method - starting point of the program
        static void Main(string[] args)
        {
            //create a new car object
            Car mycar = new Car();

            //assign values to the car's properties
            mycar.Brand = "Toyota";
            mycar.Year = 2020;
            mycar.Color = "Red";

            //call the method to display car info
            mycar.DisplayInfo();
        }
    }
}