using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingText
{
    class TextTransformer
    {
        static string text;
        public static void InputText()
        {
            Console.WriteLine("Enter the text: ");
            text = Console.ReadLine();
        }
        public static bool IsNull()
        {
            if (text == null) return true;
            else return false;
        }
        public static void IfValue(string valuetext)
        {
            valuetext = valuetext.ToUpper();
            Console.WriteLine(valuetext);
            text = null;
        }
        public static void IfNull(string nulltext)
        {
            Console.WriteLine("Transform null strings to something valuable with iteration");
            StringBuilder stringBuilder = new StringBuilder(nulltext);
            for(int i=0;i<17;i++)
            {
                stringBuilder.Append('a');
                Console.WriteLine($"Value: {stringBuilder,-18}  Lenght:  {stringBuilder.Length,3}  Capacity:  {stringBuilder.Capacity}");
            }
        }
        public static void OutputText()
        {
            if (IsNull()) IfNull(text);
            else IfValue(text);
        }
    }
}
