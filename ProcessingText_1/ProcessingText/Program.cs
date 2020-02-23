using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExampleText.text2);
            Console.WriteLine();
            TextTransformer.TextSeparator(ExampleText.text3);
            Console.WriteLine();
            TextTransformer.OutputStringArray(ExampleText.StringArray);
        }
    }
}
