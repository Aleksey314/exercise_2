using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ch = new Human();
            ch.SetName();
            ch.ToDisplay();
            Girl girl1 = new Girl();
            girl1.SetName();
            girl1.ToDisplay();
            Boy boy1 = new Boy();
            boy1.SetName();
            boy1.ToDisplay();
        }
    }
}
