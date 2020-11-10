using System;

namespace Open_Lab_10._02
{

    class Program
    {
        public class Book
        {
            private string Title;
            private string Author;
            private string Category;
            private int Pages;
            private int ReleaseDate;

            public string _Title
            {
                get;
                set;
            }
            public string _Author
            {
                get;
                set;
            }
            public string _Category
            {
                get;
                set;
            }
            public int _Pages
            {
                get;
                set;
            }
            public int _ReleaseDate
            {
                get;
                set;
            }
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            book._Title = "The Fellowship of the Ring";
            book._Author = "J. R. R. Tolkien";
            book._Category = "fantasy and adventure";
            book._Pages = 300;
            book._ReleaseDate = 1954;
            
            
            Console.WriteLine($"Title: {book._Title} ");
            Console.WriteLine($"Author: {book._Author} ");
            Console.WriteLine($"Release date: {book._ReleaseDate} ");
            Console.WriteLine($"Category of the book: {book._Category} ");
            Console.WriteLine($"Number of pages: {book._Pages} ");
        }
    }
}
