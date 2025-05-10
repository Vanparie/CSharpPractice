using System;

namespace CSharpPractice
{
    //blueprint for Trainee details
    class Trainee
    {
        public string Name;
        public string Course;
        public string Grade;

        //output trainee information
        public void DisplayReport()
        {
            Console.WriteLine($"Trainee name: {Name}");
            Console.WriteLine($"Trainee course: {Course}");
            Console.WriteLine($"Trainee Grade: {Grade}");
            Console.WriteLine();
        }
    }
    //main program logic for handling trainees
    internal class TraineeDetails
    {
        static void Main(string[] args)
        {
            //create and initialize trainee objects
            Trainee trainee1 = new Trainee { Name = "Davidson", Course = "ICT", Grade = "A" };
            Trainee trainee2 = new Trainee { Name = "Dravis", Course = "Mass Media", Grade = "B" };
            Trainee trainee3 = new Trainee { Name = "Steph", Course = "Audit", Grade = "C" };

            //Display each trainee's details
            trainee1.DisplayReport();
            trainee2.DisplayReport();
            trainee3.DisplayReport();
        }
    }
}