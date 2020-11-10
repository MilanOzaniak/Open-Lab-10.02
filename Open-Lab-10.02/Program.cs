using System;

namespace Open_Lab_10._02
{

    class Program
    {
        public class Book
        {
            private string title;
            private string author;
            private string category;
            private int pages;
            private int releaseDate;

            public string Title
            {
                get;
                set;
            }
            public string Author
            {
                get;
                set;
            }
            public string Category
            {
                get;
                set;
            }
            public int Pages
            {
                get;
                set;
            }
            public int ReleaseDate
            {
                get;
                set;
            }
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "The Fellowship of the Ring";
            book.Author = "J. R. R. Tolkien";
            book.Category = "fantasy and adventure";
            book.Pages = 300;
            book.ReleaseDate = 1954;
            
            
            Console.WriteLine($"Title: {book.Title} ");
            Console.WriteLine($"Author: {book.Author} ");
            Console.WriteLine($"Release date: {book.ReleaseDate} ");
            Console.WriteLine($"Category of the book: {book.Category} ");
            Console.WriteLine($"Number of pages: {book.Pages} ");

        }
    }
}
