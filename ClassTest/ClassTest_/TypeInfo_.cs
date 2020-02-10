using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest_
{
    class TypeInfo_
    {
        public static void SetType(string ty)
        {
            Type type_ =Type.GetType(ty);
            Console.WriteLine($"Current assembly:");
            Console.WriteLine(type_.Assembly.FullName);
        }
    }
}
