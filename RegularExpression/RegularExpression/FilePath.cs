using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class FilePath
    {
        public string path;
        public FilePath(string path) { this.path = path; }
        public bool IsPathCorrect()
        {
            Regex regex = new Regex(@"^([A-Za-z]{1}|\.{2})?:?\\?([\w\s]+\\)*[\w\s]*(\.[A-Za-z]+)?$");
            if (regex.IsMatch(path)) return true;
            else return false;
        }
        public void PrintResult()
        {
            if (IsPathCorrect()) Console.WriteLine($"Path- \"{path}\" - valid!");
            else Console.WriteLine($"Path- \"{path}\" - invalid!");
        }
    }
}
