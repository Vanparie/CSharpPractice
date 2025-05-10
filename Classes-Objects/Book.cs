//import system namespace

using System;

//group related classes together
namespace CSharpPractice
{
    //define the book class(blueprint for book details)
    class Book
    {
        //declare public fields for each book
        public string Title;
        public string Author;

        //method to display book details
        public void DisplayInfo()
        {
            //print book details using their fields
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");

        }
    }
    //define another class for the main method - entry point of the program
    internal class BookDetails
    {
        //main method - where the program starts
        static void Main(string[] args)
        {
            //create a new book object
            Book mybook = new Book();

            //assign values to the book's properties
            mybook.Title = "The River Between";
            mybook.Author = "Ngugi Wa Thiong'o";

            //call the method to display book details
            mybook.DisplayInfo();
        }
    }
}