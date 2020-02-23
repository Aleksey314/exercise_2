using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingText
{
    class ExampleText
    {
        public static string text1 = $@"One thing to keep in mind is that string methods can be culture sensitive.
This is why most of the methods accept an instance of the StringComparison enumeration.When working with strings, 
always try to avoid the methods that don’t use an explicit value of StringComparison.";
        public static string text2 = @"A string is an array of characters.
You can enumerate a string just as if it were a typical collection. 
Because a string implements IEnumerable and IEnumerable<Char>, it exposes
the GetEnumerator method that you can use to iterate over a string.";
        public static string text3 = text2+text4;
        public static string text4 = null;
        public static string[] StringArray = new string[]
        {
            "But immutable data structures also have a negative side.",
            "Immutability is useful in many scenarios.",
            null,
            "applications",
            "steps",
            text1,
        };
    }
}
