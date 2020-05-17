using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class EMail
    {
        public string mailAddress;
        public EMail(string mailAddress) { this.mailAddress = mailAddress; }
        public bool IsMailCorrect()
        {
            Regex regex = new Regex(@"^[A-Za-z0-9.!#$%&*+/\-=?^_`{|}~]+@[a-zA-Z0-9]+[A-Za-z0-9.-]*\.[A-Za-z]+$");
            if (regex.IsMatch(mailAddress)) return true;
            else return false;
        }
        public void PrintResult()
        {
            if (IsMailCorrect()) Console.WriteLine($"e-mail address- \"{mailAddress}\" - valid!");
            else Console.WriteLine($"e-mail address- \"{mailAddress}\" - invalid!");
        }
    }
}
