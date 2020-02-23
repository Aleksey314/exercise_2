using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingText
{
    class TextTransformer
    {        
        public static bool IsNull(string inputvalue)
        {
            if (inputvalue == null) return true;
            else return false;
        }
        public static void IfValue(string valuetext)
        {
            if (valuetext.Contains('\n')) TextSeparator(valuetext);
            else
            {
                valuetext = valuetext.ToUpper();
                Console.WriteLine(valuetext);
            }                      
        }
        public static void IfNull(string nulltext)
        {            
            StringBuilder stringBuilder = new StringBuilder(nulltext);
            stringBuilder.Append("-!-This string was null-!-");
            Console.WriteLine(stringBuilder);
        }
        public static void OutputText(string result)
        {
            if (IsNull(result)) IfNull(result);
            else IfValue(result);
        }
        public static void OutputStringArray(string[]arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                OutputText(arr[i]);
            }
        }
        public static void TextSeparator(string valuetext)
        {            
            string[] ts = valuetext.Split('\n');
            for(int i=0;i<ts.Length;i++)
            {               
                OutputText(ts[i]);               
            }            
        }
    }
}
