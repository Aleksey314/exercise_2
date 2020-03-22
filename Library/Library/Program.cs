using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {            
            Book book1 = new Book() { Title = "The Jungle Book", Author = "Rudyard Kipling", Genre = "Fairy tale" };
            Book book2 = new Book() { Title = "Fahrenheit 451", Author = "Ray Bradbury", Genre = "Social fantasy" };

            LibraryCardFile.CreateNewCardFileXML(Book.BooksList);
            LibraryCardFile.CreateNewCardFileJSON(Book.BooksList);

            LibraryCardFile.NewEntryInCardFileJSON(Book.EnterNewBookManually());
            LibraryCardFile.NewEntryInCardFileXML(Book.EnterNewBookManually());

            LibraryCardFile.NewEntryInCardFileJSON(book1);
            LibraryCardFile.NewEntryInCardFileXML(book2);

            LibraryCardFile.GetJsonFileContents();
            LibraryCardFile.GetXmlFileContents();
        }
    }
}
