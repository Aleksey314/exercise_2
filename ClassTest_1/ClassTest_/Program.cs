using System;
using System.Reflection;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest_
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeInfo.SetType("ClassTest_.TypeInfo");
            TypeInfo.SetType("ClassLibraryTest.Mammal,ClassLibraryTest");
            TypeInfo.SetType("ClassLibraryTest.IAnimal,ClassLibraryTest");
            TypeInfo.SetType("ClassLibraryTest.Group`1,ClassLibraryTest");            
        }
    }
}
