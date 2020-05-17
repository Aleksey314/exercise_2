using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class UrlAddress
    {
        public string urlAddress;
        public UrlAddress(string urlAddress) { this.urlAddress = urlAddress; }
        public bool IsUrlCorrect()
        {
            Regex regex = new Regex(@"^([a-z]+[a-z\.0-9]*:)?//[A-Za-z0-9]+(\.[A-Za-z0-9-_]+)+(:\d+)?(/[\w]+[\w\s-]*)*(\.[A-Za-z]+)?(\?[\w=&]+)?(#[\w]+)?$");
            if (regex.IsMatch(urlAddress)) return true;
            else return false;
        }
        public void PrintResult()
        {
            if (IsUrlCorrect()) Console.WriteLine($"URL address- \"{urlAddress}\" - valid!");
            else Console.WriteLine($"URL address- \"{urlAddress}\" - invalid!");
        }
    }
}
