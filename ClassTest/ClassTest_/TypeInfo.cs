using System;
using System.Reflection;
using ClassLibraryTest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest_
{
    class TypeInfo
    {
        static Assembly assemblyInfo = typeof(Reptile).Assembly;        
        public static void typeInfo()
        {
            foreach(Type t in  assemblyInfo.DefinedTypes)
            {
                Console.WriteLine($"The existing type is:  { t.Name} ");
                Console.WriteLine($"The members of type is:\n");
                MemberInfo[] memberInfos = t.GetMembers();                
                foreach(MemberInfo g in memberInfos)
                {
                    Console.WriteLine($"{g.Name} is a {g.MemberType}-");
                }
                Console.WriteLine();
            }
        }
    }
}
