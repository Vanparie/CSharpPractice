
using System;

namespace CSharpPractice
{
    //define the trainer class
    class Trainer
    {
        //declare public details for each trainer
        public string Name;
        public string Department;

        //method to display trainer details
        public void WelcomeMsg()
        {
            //Print message and details 
            Console.WriteLine("Hello trainer. Welcome to this online training.");
            Console.WriteLine($"Trainer name: {Name}");
            Console.WriteLine($"Trainer department: {Department}");
        }
    }
    //define another class that contains the main method
    internal class Training
    {
        
        static void Main(string[] args)
        {
            //create a new trainer object
            Trainer trainer = new Trainer();

            //assign values
            trainer.Name = "Davidson";
            trainer.Department = "Computing and Informatics";

            //call the method to print trainer details
            trainer.WelcomeMsg();
        }
    }
}