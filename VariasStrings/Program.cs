using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello world!";
            string tabs = "One\tTwo\tThree";
            string newline = "This string has\na newline";
            string unicode = "\u2153 \u3042 \u232b";
            string quotes = "\"Escaped quotes\"";
            string verbatim = @"\n \t \u0101";

            Console.WriteLine(hello);
            Console.WriteLine(tabs);
            Console.WriteLine(newline);
            Console.WriteLine(unicode);
            Console.WriteLine(quotes);
            Console.WriteLine(verbatim);
        }
    }
}
