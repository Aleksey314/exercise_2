using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Library
{
    class LibraryClass
    {
        public static string tempFolder = Path.Combine(Directory.GetCurrentDirectory(), "TempFolder");
        public static string fileXML = Path.Combine(tempFolder, "LibraryClass.xml");
        public static string fileJSON = Path.Combine(tempFolder, "LibraryClass.json");
        public static void AddNewBookInXml(Book book)
        {
            Console.WriteLine($"\nStart recording to {Path.GetFileName(fileXML)} \"{book.Title}\"");
            if (!Directory.Exists(tempFolder)) Directory.CreateDirectory(tempFolder);
            XDocument docXml;
            XElement xLibrary;
            if (!File.Exists(fileXML))
            {
                docXml = new XDocument();
                xLibrary = new XElement("Library");
                docXml.Add(xLibrary);
            }
            else
            { 
                docXml = XDocument.Load(fileXML);
                xLibrary = docXml.Element("Library");
            }            
            XElement xBook = new XElement("Book");
            XAttribute xTitle = new XAttribute("Title", book.Title);
            XElement xAuthor = new XElement("Author", book.Author);
            XElement xGenre = new XElement("Genre", book.Genre);
            xBook.Add(xTitle);
            xBook.Add(xAuthor);
            xBook.Add(xGenre);
            xLibrary.Add(xBook);            
            docXml.Save(fileXML);
            Console.WriteLine($"\nFinish recording to {Path.GetFileName(fileXML)} \"{book.Title}\"");
        }
        public static void AddNewBookInJson(Book book)
        {
            Console.WriteLine($"\nStart recording to {Path.GetFileName(fileJSON)} \"{book.Title}\"");
            if (!Directory.Exists(tempFolder)) Directory.CreateDirectory(tempFolder);
            JObject jLibrary = new JObject();
            JArray jLib = new JArray();
            if (!File.Exists(fileJSON))
            {
                jLib = new JArray();
                jLibrary = new JObject();
                jLibrary.Add("Library",jLib);
            }
            else
            {
                using (StreamReader streamReader = File.OpenText(fileJSON))
                using (JsonTextReader jsonTextReader = new JsonTextReader(streamReader))
                {
                    jLibrary = JObject.Load(jsonTextReader);
                    jLib = (JArray)jLibrary["Library"];
                }                
            }
            JObject jBook = JObject.FromObject(book);
            jLib.Add(jBook);            
            using (StreamWriter streamWriter = File.CreateText(fileJSON))
            using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
            {
                jLibrary.WriteTo(jsonTextWriter);
            }
            Console.WriteLine($"\nFinish recording to {Path.GetFileName(fileJSON)} \"{book.Title}\"");
        }
    }
}
