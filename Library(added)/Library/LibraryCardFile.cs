using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Library
{
    class LibraryCardFile
    {
        public static string tempFolder = Path.Combine(Directory.GetCurrentDirectory(), "TempFolder");
        public static string fileXML = Path.Combine(tempFolder, "LibraryCardFile.xml");
        public static string fileJSON = Path.Combine(tempFolder, "LibraryCardFile.json");

        public static void CreateNewCardFileXML(List<Book> books)
        {
            Console.WriteLine($"\nCreation a XML file with initial contents.\nStart creation XML file");            
            if (!Directory.Exists(tempFolder)) Directory.CreateDirectory(tempFolder);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            using (FileStream fileStream = File.Create(fileXML))
            {
                xmlSerializer.Serialize(fileStream, books);
            }
            Console.WriteLine($"\nFinish creation XML file");
        }
        public static void NewEntryInCardFileXML(Book book)
        {
            Console.WriteLine($"\nStart updating XML file");
            List<Book> newbooks = new List<Book>();
            using (FileStream fileStream = File.Open(fileXML, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
                newbooks = (List<Book>)xmlSerializer.Deserialize(fileStream);
            }
            newbooks.Add(book);
            using (FileStream fileStream = File.Create(fileXML))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
                xmlSerializer.Serialize(fileStream, newbooks);
            }
            Console.WriteLine($"\nFinish updating XML file");
        }
        public static void CreateNewCardFileJSON(List<Book>books)
        {
            Console.WriteLine($"\nCreation a JSON file with initial contents.\nStart creation JSON file");
            if (!Directory.Exists(tempFolder)) Directory.CreateDirectory(tempFolder);
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter fileStream = File.CreateText(fileJSON))
            {
                jsonSerializer.Serialize(fileStream, books);
            }
            Console.WriteLine($"\nFinish creation JSON file");
        }
        public static void NewEntryInCardFileJSON(Book book)
        {
            Console.WriteLine($"\nStart updating JSON file");
            List<Book> newbooks = new List<Book>();
            using (StreamReader streamReader = File.OpenText(fileJSON))
            {                
                JsonSerializer jsonSerializer = new JsonSerializer();
                newbooks=(List<Book>)jsonSerializer.Deserialize(streamReader,typeof(List<Book>));
            }
            newbooks.Add(book);
            using (StreamWriter streamWriter = File.CreateText(fileJSON))
            {                
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(streamWriter, newbooks);               
            }
            Console.WriteLine($"\nFinish updating JSON file");
        }
        public static void GetXmlFileContents()
        {
            Console.WriteLine($"\nThe XML file contains following books:");
            List<Book> books = new List<Book>();
            using (FileStream fileStream = File.Open(fileXML, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
                books = (List<Book>)xmlSerializer.Deserialize(fileStream);
            }
            foreach (Book book in books) book.PrintBookCard();
        }
        public static void GetJsonFileContents()
        {
            Console.WriteLine($"\nThe JSON file contains following books:");
            List<Book> books = new List<Book>();
            using (StreamReader streamReader = File.OpenText(fileJSON))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                books = (List<Book>)jsonSerializer.Deserialize(streamReader, typeof(List<Book>));
            }
            foreach (Book book in books) book.PrintBookCard();
        }
    }
}
