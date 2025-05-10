using System;


namespace CSharpPractice
{

    internal class InputOutputPractice
    {
        
        static void Main(string[] args)
        {
            //take user name
            Console.WriteLine("Name: ");
            string userName = Console.ReadLine();

            //take user age
            Console.WriteLine("Age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            //take user salary
            Console.WriteLine("Salary: ");
            double userSalary = Convert.ToDouble(Console.ReadLine());

            //know whether the user is a student or not

            Console.WriteLine("IsStudent: ");
            bool IsStudent = Convert.ToBoolean(Console.ReadLine());

            //print output

            Console.WriteLine("Name: " + userName);
            Console.WriteLine("Age: " + userAge);
            Console.WriteLine("Salary: " + userSalary);
            Console.WriteLine("Is Student: " + IsStudent);
            
        }
    }
}