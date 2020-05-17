using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            EMail eMail1 = new EMail("olle-16@mail.ru");
            eMail1.PrintResult();

            EMail eMail2 = new EMail("14oll.e-16@ma.-il.ru");
            eMail2.PrintResult();

            FilePath filePath1 = new FilePath(@"C:\Documents\News9letters\Summer2018.pdf");
            filePath1.PrintResult();

            FilePath filePath2 = new FilePath(@"..\Publications\TravelBrochure");
            filePath2.PrintResult();

            FilePath filePath3 = new FilePath(@"\Program Files\Custom Utilities\StringFinder.exe");
            filePath3.PrintResult();

            UrlAddress urlAddress1 = new UrlAddress(@"http://www.example.com:80/path/to/myfile.html?key1=value1&key2=value2#SomewhereInTheDocument");
            urlAddress1.PrintResult();

            UrlAddress urlAddress2 = new UrlAddress(@"https://docs.microsoft.com:80/ru-ru/dotnet/standard");
            urlAddress2.PrintResult();

            UrlAddress urlAddress3 = new UrlAddress(@"//doc.fog.ff/ghj");
            urlAddress3.PrintResult();
        }
    }
}
