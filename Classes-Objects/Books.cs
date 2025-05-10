using System;

namespace CSharpPractice
{
    //blueprint for books basic details
    class Books
    {
        public string Title;
        public string Author;

        //output book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine();    //Adds a blank line for readability
        }
    }
    //main program logic for handling books
    internal class BookDetails
    {
        static void Main(string[] args)
        {
            //create and initialize book objects
            Books book1 = new Books {Title = "The River Between", Author = "Ngugi Wa Thiongo"};
            Books book2 = new Books { Title = "Thigs Fall apart", Author = "Chinua Achebe" };
            Books book3 = new Books { Title = "Cry Me a River", Author = "Davidson Leparie" };

            //display each book's details
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
        }
    }
}