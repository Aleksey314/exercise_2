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
        public static Assembly assemblyInfo = typeof(Reptile).Assembly;        
        public static void typeInfo()
        {
            foreach(Type t in  assemblyInfo.DefinedTypes)
            {
                Console.WriteLine($"The existing type is:  { t.Name} ");
                Console.WriteLine($"The members of type is:\n");                                
                foreach(MemberInfo g in t.GetMembers())
                {
                    Console.WriteLine($"{g.Name} is a {g.MemberType}-");
                }
                Console.WriteLine();
            }
        }
        public static void SetType(string ty)
        {
            Type type = Type.GetType(ty);
            Console.WriteLine($"\nAssembly of type \"{type.Name}\": {type.Assembly.FullName}");
            Console.WriteLine($"This type contains:");
            foreach(MethodInfo method in type.GetMethods())
            {
                string stat = ""; if (method.IsStatic) stat = "static ";
                string virt = ""; if (method.IsVirtual) virt = "virtual ";
                string priv = ""; if (method.IsPrivate) priv = "private ";
                string publ = ""; if (method.IsPublic) publ = "public ";
                string abst = "";if (method.IsAbstract) abst = "abstract ";                
                Console.Write($"Method:  {publ}{priv} {stat} {virt}{abst} {method.ReturnType.Name} {method.Name} (");
                ParameterInfo[] parameters = method.GetParameters();
                for(int i=0;i<parameters.Length;i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i < parameters.Length-1) { Console.Write(" , "); }                   
                }
                Console.WriteLine(")");
            }

            foreach (PropertyInfo property in type.GetProperties())
            {                
                Console.WriteLine($"Property:  {property.PropertyType.Name} {property.Name}");
                Console.WriteLine($"           {property.GetMethod.Name}");
                Console.WriteLine($"           {property.SetMethod.Name}");
            }
            foreach(FieldInfo field in type.GetFields())
            {
                Console.WriteLine($"Field:   {field.FieldType.Name} {field.Name}");
            }
            foreach(ConstructorInfo constructor in type.GetConstructors())
            {
                Console.Write($"Constructor:   {constructor.DeclaringType.Name} (");
                ParameterInfo[] consparam = constructor.GetParameters();
                for(int i=0;i<consparam.Length;i++)
                {
                    Console.Write($"{consparam[i].ParameterType.Name} {consparam[i].Name}");
                    if (i < consparam.Length - 1) { Console.Write(" , "); }
                }
                Console.WriteLine(")");
            }
            foreach(Type t in type.GetInterfaces())
            {
                Console.WriteLine($"Interface:   {t.Name}");
            }
            foreach(Type t in type.GetNestedTypes())
            {
                string clas = "";if (t.IsClass) clas = "Class";                
                string publ = "";if (t.IsPublic) clas = "Public";
                Console.WriteLine($"Nested Type:   {publ} {clas} {t.Name}");
            }
        }
    }
}
