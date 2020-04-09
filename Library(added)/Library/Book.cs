using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{    
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public Book() { }
        public static Book EnterNewBookManually()
        {
            Console.WriteLine("\nEnter new book manually;");
            Book book = new Book();
            Console.Write("Title:\t");
            book.Title = Console.ReadLine();
            Console.Write("Author:\t");
            book.Author = Console.ReadLine();
            Console.Write("Genre:\t");
            book.Genre = Console.ReadLine();
            return book;
        }
        public void PrintBookCard()
        {
            Console.WriteLine($"\nTitle:\t{Title}");
            Console.WriteLine($"Author:\t{Author}");
            Console.WriteLine($"Genre:\t{Genre}");
        }
        public static List<Book> BooksList = new List<Book>
        {
            new Book(){Title="The Adventure of Sherlock Holmes",Author="Arthur Conan Doyle",Genre="Detective"},
            new Book(){Title="Treasure Island",Author="Robert Louis Stevenson",Genre="Adventures"},
            new Book(){Title="The Invisible Man",Author="Herbert Wells",Genre="Fantasy"},
        };
    }
}
