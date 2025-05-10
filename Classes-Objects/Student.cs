
using System;


namespace CSharpPractice
{
    // Define a class called Student – this is your blueprint for a student
    class Student
    {
        // Define public fields (characteristics) for each student
        public string Name;
        public int Age;
        public string Course;

        // Define a method inside the Student class to introduce the student
        public void Introduce()
        {
            // This method prints the student's details using their fields
            Console.WriteLine($"Hi, my name is {Name}, I am {Age} years old, studying {Course}.");
        }
    }

    // Define another class that contains the Main method (the program entry point)
    internal class StudentApp
    {
        // The Main method – this is where the program starts running
        static void Main(string[] args)
        {
            // Create a new Student object from the Student class blueprint
            Student student1 = new Student();

            // Assign values to the student's fields
            student1.Name = "Alice";
            student1.Age = 21;
            student1.Course = "Software Engineering";

            // Call the Introduce method to print the student's details
            student1.Introduce();
        }
    }
}
